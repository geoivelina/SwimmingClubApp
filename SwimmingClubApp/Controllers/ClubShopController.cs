using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Models.ClubShop;
using SwimmingClubApp.Services.Products;
using SwimmingClubApp.Services.Products.Models;
using System.Linq;

namespace SwimmingClubApp.Controllers
{
    public class ClubShopController : Controller
    {
        private readonly SimmingClubDbContext data;
        private readonly IProductService products;

        public ClubShopController(SimmingClubDbContext data, IProductService products)
        {
            this.data = data;
            this.products = products;
        }

        public IActionResult AddProduct()
        {
            return View(new ProductFormModel()
            {
                SizesList = this.products.AllSizeOptions(),
                ProductCategories = this.products.AllProductCategories()
            });
        }

        [HttpPost]
        public IActionResult AddProduct(ProductFormModel product)
        {
            if (!this.products.ProductCategoriesExist(product.ProductCategoryId))
            {
                this.ModelState.AddModelError(nameof(product.ProductCategoryId), "Category does not exist");
            }

            foreach (var size in product.SizesList)
            {
                if (!this.data.SizeOptions.Any(p => p.Id == size.Id))
                {
                    this.ModelState.AddModelError(nameof(size.Id), "Size does not exist");
                }
            }

            if (!ModelState.IsValid)
            {
                product.SizesList = this.products.AllSizeOptions();
                product.ProductCategories = this.products.AllProductCategories();
                return View(product);

            }
           

            this.products.CreateProduct(product.Name, product.Image, product.Price, product.ProductCategoryId, product.SizesList);

            return RedirectToAction(nameof(AllProducts));
        }

        public IActionResult Details(int id)
        {
            var product = this.data
                .Products
                .Where(n => n.Id == id)
                .Select(n => new ProductDetailsViewModel()
                {
                    Image = n.Image,
                    Name = n.Name,
                    Price = n.Price,
                    //SizeOptions = n.Sizes
                })
                .FirstOrDefault();

            return View(product);
        }

   
        public IActionResult EditProduct(int id)
        {
            var product = this.products.Details(id);

            if (!this.products.ProductCategoriesExist(product.ProductCategoryId))
            {
                this.ModelState.AddModelError(nameof(product.ProductCategoryId), "Category does not exist");
            }
            return View(new ProductFormModel
            {
                Name = product.Name,
                Image = product.Image,
                Price = product.Price,
                ProductCategoryId = product.ProductCategoryId,
                SizesList = product.SizesList,
            });
        }

        [HttpPost]
        public IActionResult EditProduct(ProductFormModel product)
        {
            //var product = this.data.Products.Where(p => p.Id == id);

            //if (product == null)
            //{

            //}
            return View();
        }

        public IActionResult DeleteProduct(int id)

        {
            return View();
        }

        public IActionResult AllProducts([FromQuery] AllProductsQueryModel query)
        {
            var products = this.products.All(query.Category, query.Sorting, query.CurrentPage, AllProductsQueryModel.ProductsPerPage);

            var categories = this.products.ProductCategories();

            query.TotalProducts = products.TotalProducts;
            query.Categories = categories;
            query.Products = products.Products;

            return View(query);
        }


    }
}
