using SwimmingClubApp.Models.ClubShop;

namespace SwimmingClubApp.Services.Products.Models
{
    public class ProductQueryServiceModel
    {
        public int CurrentPage { get; set; }
        public int ProductsPerPage { get; set; }
        public int TotalProducts { get; set; }
        public string Category { get; set; } = null!;
        public IEnumerable<ProductServiceMOdel> Products { get; set; } = new List<ProductServiceMOdel>();
    }
}
