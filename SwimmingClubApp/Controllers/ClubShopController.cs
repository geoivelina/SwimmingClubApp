using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Models.ClubShop;
using SwimmingClubApp.Services.Products;
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
            return View(new AddProductFormModel()
            {
                Sizes = this.GetSizeOptions(),
                ProductCategories = this.GetProductCategories()
            });
        }

        [HttpPost]
        public IActionResult AddProduct(AddProductFormModel product)
        {
            if (!this.data.ProductCategories.Any(p => p.Id == product.ProductCategoryId))
            {
                this.ModelState.AddModelError(nameof(product.ProductCategoryId), "Category does not exist");
            }

            foreach (var size in product.Sizes)
            {
                if (!this.data.SizeOptions.Any(p => p.Id == size.Id))
                {
                    this.ModelState.AddModelError(nameof(size.Id), "Size does not exist");
                }
            }

            if (!ModelState.IsValid)
            {
                product.Sizes = this.GetSizeOptions();
                product.ProductCategories = this.GetProductCategories();
                return View(product);

            }

            var newProduct = new Product
            {
                Name = product.Name,
                Image = product.Image,
                Price = product.Price,
                ProductCategoryId = product.ProductCategoryId
            };

            foreach (var sizeOption in product.SizesList)
            {
                var size = this.data.SizeOptions.FirstOrDefault(s => s.Id == sizeOption);
                newProduct.Sizes.Add(new ProductSize
                {
                    SizeOption = size,
                });
            }

            this.data.Products.Add(newProduct);
            this.data.SaveChanges();

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
            var product = this.data.Products.Where(p => p.Id == id);

            if (product == null)
            {

            }
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
            query.Categories= categories;
            query.Products = products.Products;
           
            return View(query);
        }
        private IEnumerable<ProductCategoryViewModel> GetProductCategories()
        {
            return this.data
                .ProductCategories
                .Select(p => new ProductCategoryViewModel
                {
                    Id = p.Id,
                    Name = p.CategoryName
                })
                .ToList();
        }

        private List<ProductSizeViewModel> GetSizeOptions()
        {
            return this.data
                .SizeOptions
                .Select(s => new ProductSizeViewModel
                {
                    Id = s.Id,
                    SizeDescription = s.Description
                })
                .ToList();
        }
    }
}
