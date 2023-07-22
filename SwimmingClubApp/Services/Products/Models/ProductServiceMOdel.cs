using SwimmingClubApp.Models.ClubShop;
using System.ComponentModel.DataAnnotations;

namespace SwimmingClubApp.Services.Products.Models
{
    public class ProductServiceModel
    {
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        public string Name { get; set; } = null!;

        [Display(Name= "Image URL")]
        public string Image { get; set; } = null!;
        public decimal Price { get; set; }



    }
}