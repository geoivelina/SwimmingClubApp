using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Models.ClubShop;
using System.Linq;

namespace SwimmingClubApp.Controllers
{
    public class ClubShopController : Controller
    {
        private readonly SimmingClubDbContext data;

        public ClubShopController(SimmingClubDbContext data)
        {
            this.data = data;
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
        
            //foreach (var id in product.SizeOptions)
            //{
            //    if (!this.data.SizeOptions.Any(p => p.Id == id))
            //    {
            //        this.ModelState.AddModelError(nameof(product.SizeOptionId), "Category does not exist");
            //    }
            //}

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

            //foreach (var optionSIze in product.Sizes)
            //{
            //    var option = this.data.SizeOptions.FirstOrDefault(x => x.Description == optionSIze.SizeDescription);
            //    if (option == null)
            //    {
            //        option = new SizeOption { Description = optionSIze.SizeDescription };
            //    }
            //    newProduct.Sizes.Add(new ProductSize
            //    {
            //        SizeOption = option,

            //    });
            //}
           // product.Sizes = SizesList;
            this.data.Products.Add(newProduct);
            this.data.SaveChanges();

            return RedirectToAction(nameof(AllProducts));
        }


        public IActionResult EditProduct(int id)
        {
            return View();
        }

        public IActionResult DeleteProduct(int id)

        {
            return View();
        }

        public IActionResult AllProducts()
        {
            var product = this.data
               .Products
               .OrderByDescending(p => p.Id)
               .Select(n => new ProductViewModel()
               {
                   Id = n.Id,
                   Image = n.Image,
                   Name = n.Name,
                   Price = n.Price
               })
               .ToList();

            return View(product);
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
