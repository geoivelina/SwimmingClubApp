using SwimmingClubApp.Models.ClubShop;
using System.ComponentModel.DataAnnotations;

namespace SwimmingClubApp.Services.Products.Models
{
    public class ProductServiceMOdel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Image { get; set; } = null!;
        public decimal Price { get; set; }
        public ProductSorting Sorting { get; set; }
        public string Category { get; set; } = null!;
        public IEnumerable<string> Categories { get; set; } = new List<string>();

    }
}
