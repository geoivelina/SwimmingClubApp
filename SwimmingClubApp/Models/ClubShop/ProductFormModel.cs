using Microsoft.EntityFrameworkCore;
using SwimmingClubApp.Services.Products.Models;
using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.Product;

namespace SwimmingClubApp.Models.ClubShop
{
    public class ProductFormModel
    {

        [Required]
        [Display(Name = "Product Name")]
        [StringLength(ProductNameMaxLength, MinimumLength = ProductNameMinLength, ErrorMessage = "Product Name field must be between {2} and {1} symbols")]
        public string Name { get; set; } = null!;

        [Required]
        [Display(Name = "Image URL")]
        [Url]
        public string Image { get; set; } = null!;


        [Required]
        [Precision(18, 2)]
        public decimal Price { get; set; }


        [Required]
        [Display(Name = "Product Category")]
        public int ProductCategoryId { get; set; }
        public IEnumerable<ProductCategoryServiceModel> ProductCategories { get; set; } = new List<ProductCategoryServiceModel>();

        public IEnumerable<int> SizesList { get; set; } = new List<int>();

        public List<ProductSizeServiceModel> AllSizes { get; set; } = new List<ProductSizeServiceModel>();


    }
}
