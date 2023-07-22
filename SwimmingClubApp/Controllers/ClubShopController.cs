using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Models.ClubShop;
using SwimmingClubApp.Services.Products;
using SwimmingClubApp.Services.Products.Models;

using static SwimmingClubApp.Areas.Admin.AdminConstants;

namespace SwimmingClubApp.Controllers
{
   // [Authorize(Roles = AdminRoleName)]
    public class ClubShopController : Controller
    {
        private readonly IProductService products;

        public ClubShopController( IProductService products)
        {
            this.products = products;
        }

        public IActionResult AddProduct()
        {
            return View(new ProductFormModel()
            {
                AllSizes = this.products.AllSizeOptions(),
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

            foreach (var size in product.AllSizes)
            {
                if (!this.products.AllSizeOptions().Any(p => p.Id == size.Id))
                {
                    this.ModelState.AddModelError(nameof(size.Id), "Size does not exist");
                }
            }

            if (!ModelState.IsValid)
            {
                product.AllSizes = this.products.AllSizeOptions();
                product.ProductCategories = this.products.AllProductCategories();
                return View(product);

            }
           

            this.products.CreateProduct(product.Name, product.Image, product.Price, product.ProductCategoryId, product.AllSizes);

            return RedirectToAction(nameof(AllProducts));
        }

        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            if (!this.products.ProductExists(id))
            {
                return BadRequest();
            }
            var product = this.products.ProductDetails(id);

            return View(product);
        }
   
        public IActionResult EditProduct(int id)
        {
            var product = this.products.ProductDetails(id);

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
                AllSizes = product.SizesList,
            });
        }

        [HttpPost]
        public IActionResult EditProduct(int id, ProductFormModel product)
        {
            
            return RedirectToAction(nameof(Details));
        }

        public IActionResult DeleteProduct(int id)

        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult AllProducts([FromQuery] AllProductsQueryModel query)
        {
            var products = this.products.All(query.Category, query.Sorting, query.CurrentPage,                AllProductsQueryModel.ProductsPerPage);


            query.TotalProductsCount = products.TotalProducts;
            query.Products = products.Products;

            var categories = this.products.ProductCategoriesNames();
            query.Categories = categories;

            return View(query);
        }


    }
}
