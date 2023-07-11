using SwimmingClubApp.Data;
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
            var queryProduct = this.data.Products.AsQueryable();

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

        public IEnumerable<string> ProductCategories()
        {
            return this.data
                  .ProductCategories
                  .Select(c => c.CategoryName)
                  .Distinct()
                  .ToList();
        }
    }
}
