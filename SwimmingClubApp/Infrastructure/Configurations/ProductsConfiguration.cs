using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Services.Data.Models;

namespace SwimmingClubApp.Infrastructure.Configurations
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
                    Image = "https://thumbs.dreamstime.com/b/sports-bottle-silhouette-icon-black-simple-illustration-plastic-container-scale-handle-water-contour-isolated-230479543.jpg",
                    Name = "Star Swimming Club Bottle",
                    Price = 7.00m,
                    ProductCategoryId = 4,
                    Sizes = new List<ProductSize>(13)
                    },
                new Product()
                {
                    Id = 2,
                    Image = "https://tse3.mm.bing.net/th?id=OIP.V3pt_Mlm8RMFF51PfXO8qQHaHa&pid=Api",
                    Name = "Fins",
                    Price = 30.00m,
                    ProductCategoryId = 4,
                     Sizes = new List<ProductSize>(13)
                },
                new Product()
                {
                    Id = 3,
                    Image = "https://tse1.mm.bing.net/th?id=OIP.SJjMXsjJV7NIePPD-UDjEAHaHa&pid=Api",
                    Name = "Adult Googles",
                    Price = 11.00m,
                    ProductCategoryId = 4,
                    Sizes = new List<ProductSize>(14)
                },
                new Product()
                {
                    Id = 4,
                    Image = "https://dejpknyizje2n.cloudfront.net/svgcustom/clipart/preview/a5921c08923f404586ef252ada57626a.png",
                    Name = "Star Swimming Club Hat",
                    Price = 5.00m,
                    ProductCategoryId = 4,
                    Sizes = new List<ProductSize>(13)
                },
                new Product()
                {
                    Id = 5,
                    Image = "https://tse2.mm.bing.net/th?id=OIP._Rm-iwyJeCelyO1zNt4WygHaHa&pid=Api",
                    Name = "Kickboard",
                    Price = 15.00m,
                    ProductCategoryId = 4,
                     Sizes = new List<ProductSize>(13)
                },
                 new Product()
                {
                    Id = 6,
                    Image = "https://tse4.mm.bing.net/th?id=OIP.GzxZvy7xMdsGgEYBh8QeEAAAAA&pid=Api",
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
