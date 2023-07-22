using SwimmingClubApp.Models.ClubShop;
using System.ComponentModel.DataAnnotations;

namespace SwimmingClubApp.Services.Products.Models
{
    public class AllProductsQueryModel
    {
        public const int ProductsPerPage = 3;
        public string Category { get; set; } = null!;
        public ProductSorting Sorting { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int TotalProductsCount { get; set; }
        public IEnumerable<string> Categories { get; set; } = new List<string>();
        public IEnumerable<ProductServiceModel> Products { get; set; } = new List<ProductServiceModel>();


    }
}
