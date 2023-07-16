using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Models.ClubShop;
using SwimmingClubApp.Services.Products.Models;

namespace SwimmingClubApp.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly SimmingClubDbContext data;

        public ProductService(SimmingClubDbContext data)
        {
            this.data = data;
        }

        public ProductQueryServiceModel All(string category, ProductSorting sorting, int currentPage, int productsPerPage)
        {
            var queryProduct = this.data.Products.Where(p => p.IsAvtive).AsQueryable();

            if (!string.IsNullOrWhiteSpace(category))
            {
                queryProduct = queryProduct.Where(p => p.ProductCategory.CategoryName == category);
            }

            queryProduct = sorting switch
            {
                ProductSorting.Alphabetically => queryProduct.OrderBy(p => p.Name),
                ProductSorting.Price => queryProduct.OrderBy(p => p.Price),
                _ => queryProduct.OrderByDescending(p => p.Id)
            };

            var totalProducts = queryProduct.Count();

            var products = queryProduct
               .Skip((currentPage - 1) * productsPerPage)
               .Take(productsPerPage)
                .Select(n => new ProductServiceMOdel()
                {
                    Id = n.Id,
                    Image = n.Image,
                    Name = n.Name,
                    Price = n.Price,
                    Category = n.ProductCategory.CategoryName
                })
                .ToList();

            return new ProductQueryServiceModel
            {
                TotalProducts = totalProducts,
                CurrentPage = currentPage,
                ProductsPerPage = productsPerPage,
                Products = products,
            };
        }

        public IEnumerable<ProductCategoryServiceModel> AllProductCategories()
        {
            return this.data
                .ProductCategories
                .Select(p => new ProductCategoryServiceModel
                {
                    Id = p.Id,
                    Name = p.CategoryName
                })
                .ToList();
        }

        public List<ProductSizeServiceModel> AllSizeOptions()
        {
            return this.data
                .SizeOptions
                .Select(s => new ProductSizeServiceModel
                {
                    Id = s.Id,
                    SizeDescription = s.Description
                })
                .ToList();
        }

        public int CreateProduct(string name, string image, decimal price, int productCategoryId, List<ProductSizeServiceModel> sizesList)
        {
            var newProduct = new Product
            {
                Name = name,
                Image = image,
                Price = price,
                ProductCategoryId = productCategoryId,
            };

            foreach (var sizeOption in sizesList)
            {
                var size = this.data.SizeOptions.FirstOrDefault(s => s.Id == sizeOption.Id);
                newProduct.Sizes.Add(new ProductSize
                {
                    SizeOption = size,
                });
            }

            this.data.Products.Add(newProduct);
            this.data.SaveChanges();

            return newProduct.Id;
        }

        public ProductServiceMOdel Details(int id)
        {
            return this.data.Products
                 .Where(p => p.Id == id)
                 .Select(p => new ProductServiceMOdel
                 {
                     Id = p.Id,
                     Image = p.Image,
                     Name = p.Name,
                     Price = p.Price,
                     Category = p.ProductCategory.CategoryName,
                     ProductCategoryId = p.ProductCategoryId,
                     SizesList = p.Sizes.Select(s => new ProductSizeServiceModel
                     {
                         Id = s.Id,
                         SizeDescription = s.SizeOption.Description,
                         IsChecked = s.SizeOption.IsChecked
                     }).ToList()
                 })
                 .FirstOrDefault();
        }

        public IEnumerable<string> ProductCategories()
        {
            return this.data
                  .ProductCategories
                  .Select(c => c.CategoryName)
                  .Distinct()
                  .ToList();
        }

        public bool ProductCategoriesExist(int productCategoryId)
        {
            return !this.data.ProductCategories.Any(p => p.Id == productCategoryId);
        }
    }
}
