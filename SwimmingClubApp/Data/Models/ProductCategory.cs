using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.ProductCategory;

namespace SwimmingClubApp.Services.Data.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string CategoryName { get; set; } = null!;

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
