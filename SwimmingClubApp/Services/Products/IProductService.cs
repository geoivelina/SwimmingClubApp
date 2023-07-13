using SwimmingClubApp.Models.ClubShop;
using SwimmingClubApp.Services.Products.Models;

namespace SwimmingClubApp.Services.Products
{
    public interface IProductService
    {
        ProductQueryServiceModel All(string category, ProductSorting sorting, int currentPage, int productsPerPage);
        IEnumerable<string> ProductCategories();

        IEnumerable<ProductCategoryServiceModel> AllProductCategories();
        List<ProductSizeServiceModel> AllSizeOptions();
        bool ProductCategoriesExist(int productCategoryId);

        ProductServiceMOdel Details(int id);

        int CreateProduct(string name,string image,decimal price, int productCategoryId, List<ProductSizeServiceModel> sizesList);
    }
}
