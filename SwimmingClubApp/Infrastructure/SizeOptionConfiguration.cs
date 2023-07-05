using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Infrastructure
{
    internal class SizeOptionConfiguration : IEntityTypeConfiguration<SizeOption>
    {
        public void Configure(EntityTypeBuilder<SizeOption> builder)
        {
            builder.HasData(CreateSizeOptions());
        }

        private List<SizeOption> CreateSizeOptions()
        {
            var productSizes = new List<SizeOption>()
            {
                new SizeOption()
                {
                    Id = 1,
                    Description = "Kids M"
                },
                new SizeOption()
                {
                    Id = 2,
                   Description= "Kids L"
                },
                new SizeOption()
                {
                    Id = 3,
                   Description = "Kids XL"
                },
                new SizeOption()
                {
                    Id = 4,
                   Description = "Adult XS"
                },
                new SizeOption()
                {
                    Id = 5,
                   Description = "Adult S"
                },
                new SizeOption()
                {
                    Id = 6,
                   Description = "Adult M"
                },
                new SizeOption()
                {
                    Id = 7,
                   Description = "Adult L"
                },
                new SizeOption()
                {
                    Id = 8,
                  Description = "Adult XL"
                },
                new SizeOption()
                {
                    Id = 9,
                   Description = "Age 7 - 8"
                },
                new SizeOption()
                {
                    Id = 10,
                   Description = "Age 9 - 11"
                },
                new SizeOption()
                {
                    Id = 11,
                   Description = "Age 12 - 13"
                },
                new SizeOption()
                {
                    Id = 12,
                   Description = "Junior"
                },
                new SizeOption()
                {
                    Id = 13,
                   Description = "None"
                }
                ,
                new SizeOption()
                {
                    Id = 14,
                   Description = "Adult"
                }
            };

            return productSizes;
        }
    }
}
