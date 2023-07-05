using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Infrastructure
{
    internal class ProductsConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(CreateProducts());
        }

        private List<Product> CreateProducts()
        {
            var products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Image = "/wwwroot/img/Eshop/bottle.jpg",
                    Name = "Star Swimming Club Bottle",
                    Price = 7.00m,
                    ProductCategoryId = 4,
                    Sizes = new List<ProductSize>(13)
                    },
                new Product()
                {
                    Id = 2,
                    Image = "/wwwroot/img/Eshop/Fins.jpg",
                    Name = "Fins",
                    Price = 30.00m,
                    ProductCategoryId = 4,
                     Sizes = new List<ProductSize>(13)
                },
                new Product()
                {
                    Id = 3,
                    Image = "/wwwroot/img/Eshop/googles.jpg",
                    Name = "Adult Googles",
                    Price = 11.00m,
                    ProductCategoryId = 4,
                    Sizes = new List<ProductSize>(14)
                },
                new Product()
                {
                    Id = 4,
                    Image = "/wwwroot/img/Eshop/Hat.jpg",
                    Name = "Star Swimming Club Hat",
                    Price = 5.00m,
                    ProductCategoryId = 4,
                    Sizes = new List<ProductSize>(13)
                },
                new Product()
                {
                    Id = 5,
                    Image = "/wwwroot/img/Eshop/KickBoard.jpg",
                    Name = "Kickboard",
                    Price = 15.00m,
                    ProductCategoryId = 4,
                     Sizes = new List<ProductSize>(13)
                },
                 new Product()
                {
                    Id = 6,
                    Image = "/wwwroot/img/Eshop/towel.jpg",
                    Name = "Star Swimming Club Towel",
                    Price = 15.00m,
                    ProductCategoryId = 4,
                     Sizes = new List<ProductSize>(13)
                }
            };

            return products;
        }
    }
}
