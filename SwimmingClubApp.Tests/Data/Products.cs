using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Services.Data.Models;

namespace SwimmingClubApp.Tests.Data
{
    public static class Products
    {
        public static IEnumerable<Product> ProductsData
            => new List<Product>()
            {
                new Product()
            {
                    Id = 1,
                    Name = "Swimming Hat",
                    Price = 10.00m,
                    Image = "http://somelingk.com",
                    IsAvtive = true,
                    ProductCategoryId = 4,
                    Sizes = new List<ProductSize>(13)
                },
                new Product()
            {
                    Id = 2,
                    Name = "Hoodie",
                    Price = 10.00m,
                    Image = "http://somelingk.com",
                    IsAvtive = true,
                    ProductCategoryId = 1,
                    Sizes = new List<ProductSize>()
                    {
                        new ProductSize()
                        {
                            Id= 9
                        },
                        new ProductSize()
                        {
                            Id= 10
                        },
                        new ProductSize()
                        {
                            Id= 11
                        }
                    }
                }
            };
    }
}

