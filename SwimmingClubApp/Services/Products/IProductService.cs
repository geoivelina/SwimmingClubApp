using SwimmingClubApp.Models.ClubShop;
using SwimmingClubApp.Services.Products.Models;

namespace SwimmingClubApp.Services.Products
{
    public interface IProductService
    {
        ProductQueryServiceModel All(string category, ProductSorting sorting, int currentPage, int productsPerPage);
        IEnumerable<string> ProductCategories();
    }
}
