using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SwimmingClubApp.Data.DataConstants;
using static SwimmingClubApp.Data.DataConstants.Product;
using static SwimmingClubApp.Data.DataConstants.ProductCategory;

namespace SwimmingClubApp.Models.ClubShop
{
    public class AddProductFormModel
    {

        [Required]
        [Display(Name = "Product Name")]
        [StringLength(ProductNameMaxLength, MinimumLength = ProductNameMinLength, ErrorMessage = "Product Name field must be between {2} and {1} symbols")]
        public string Name { get; set; } = null!;

        [Required]
        [Display(Name = "Image URL")]
        public string Image { get; set; } = null!;


        [Required]
        [Precision(18, 2)]
        public decimal Price { get; set; }


        [Required]
        [Display(Name = "Product Category")]
        public int ProductCategoryId { get; set; }
        public IEnumerable<ProductCategoryViewModel> ProductCategories { get; set; } = new List<ProductCategoryViewModel>();

        public IEnumerable<ProductSizeViewModel> Sizes { get; set; } = new List<ProductSizeViewModel>();

        public IEnumerable<int> SizesList { get; set; } = new List<int>();

    }
}
