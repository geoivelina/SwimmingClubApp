using Microsoft.EntityFrameworkCore;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;
using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.Product;

namespace SwimmingClubApp.Services.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(ProductNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string Image { get; set; } = null!;


        [Required]
        [Precision(18, 2)]
        public decimal Price { get; set; }

        public bool IsAvtive { get; set; } = true;

        [Required]
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; } = null!;

        public List<ProductSize> Sizes { get; set; } = new List<ProductSize>();


    }
}
