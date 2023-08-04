using SwimmingClubApp.Data;
using SwimmingClubApp.Services.Products.Models;

namespace SwimmingClubApp.Services.Products
{
    public interface IProductService
    {
        int CreateProduct(string name, string image, decimal price, int productCategoryId, List<ProductSizeServiceModel> sizesList);
        int EditProduct(int id,string name, string image, decimal price, int productCategoryId, List<ProductSizeServiceModel> sizesList);
        void DeleteProduct(int id);
        bool ProductExists(int id);
        ProductDetailsServiceModel ProductDetails(int id);
        ProductQueryServiceModel AllProducts(string category= null,ProductSorting sorting = ProductSorting.Alphabetically, int currentPage = 1, int productsPerPage = int.MaxValue);
        IEnumerable<string> ProductCategoriesNames();

        IEnumerable<ProductCategoryServiceModel> AllProductCategories();
        List<ProductSizeServiceModel> AllSizeOptions();
        bool ProductCategoriesExist(int productCategoryId);



    }
}
