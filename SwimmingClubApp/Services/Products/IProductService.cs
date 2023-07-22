using SwimmingClubApp.Models.ClubShop;
using SwimmingClubApp.Services.Products.Models;

namespace SwimmingClubApp.Services.Products
{
    public interface IProductService
    {
        int CreateProduct(string name, string image, decimal price, int productCategoryId, List<ProductSizeServiceModel> sizesList);
        bool ProductExists(int id);
        ProductDetailsServiceModel ProductDetails(int id);
        ProductQueryServiceModel All(string category,ProductSorting sorting, int currentPage = 1, int productsPerPage = 1);
        IEnumerable<string> ProductCategoriesNames();

        IEnumerable<ProductCategoryServiceModel> AllProductCategories();
        List<ProductSizeServiceModel> AllSizeOptions();
        bool ProductCategoriesExist(int productCategoryId);



    }
}
