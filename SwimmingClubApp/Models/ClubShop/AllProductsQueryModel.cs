using SwimmingClubApp.Services.Products.Models;
using System.ComponentModel.DataAnnotations;

namespace SwimmingClubApp.Models.ClubShop
{
    public class AllProductsQueryModel
    {
        public const int ProductsPerPage = 3;
        public int CurrentPage { get; set; } = 1;
        public int TotalProducts { get; set; }
        public string Category { get; set; } = null!;
        public IEnumerable<string> Categories { get; set; } = new List<string>();

        [Display(Name = "Sort By")]
        public ProductSorting Sorting { get; set; }
        public IEnumerable<ProductServiceMOdel> Products { get; set; } = new List<ProductServiceMOdel>();
    }
}
