using SwimmingClubApp.Infrastructure.Mapping;
using SwimmingClubApp.Services.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace SwimmingClubApp.Services.Products.Models
{
    public class ProductServiceModel : IMapFrom<Product>, IMapTo<Product>
    {
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        public string Name { get; set; } = null!;

        [Display(Name= "Image URL")]
        public string Image { get; set; } = null!;
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

        [Display(Name = "Category")]
        public int ProductCategoryId { get; set; }
        public ProductCategoryServiceModel ProductCategory { get; set; } = null!;

        public List<ProductSizeServiceModel> SizesList { get; set; } = new List<ProductSizeServiceModel>();

    }
}