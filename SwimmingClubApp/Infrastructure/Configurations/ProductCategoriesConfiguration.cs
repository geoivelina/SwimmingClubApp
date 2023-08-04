using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwimmingClubApp.Services.Data.Models;

namespace SwimmingClubApp.Infrastructure.Configurations
{
    internal class ProductCategoriesConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasData(CreateProductCategory());
        }
        private List<ProductCategory> CreateProductCategory()
        {
            List<ProductCategory> categories = new List<ProductCategory>()
            {
                new ProductCategory()
                {
                    Id= 1,
                    CategoryName = "Junior"
                },
                 new ProductCategory()
                {
                    Id= 2,
                    CategoryName = "Women"
                },
                  new ProductCategory()
                {
                    Id= 3,
                    CategoryName = "Men"
                },
                  new ProductCategory()
                  {
                      Id = 4,
                      CategoryName = "Traning Aids"
                  }
            };
            return categories;
        }
    }
}

