using System.ComponentModel.DataAnnotations;

namespace SwimmingClubApp.Models.ClubShop
{
    public class ProductListingViewModel 
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Image { get; set; } = null!;
        public decimal Price { get; set; }

        [Display(Name = "Sort By")]
        public ProductSorting Sorting { get; set; }
        public string Category { get; set; } = null!;
        public IEnumerable<string> Categories { get; set; } = new List<string>();
        public IEnumerable<ProductDetailsViewModel> Products { get; set; } = new List<ProductDetailsViewModel>();

    }
}
