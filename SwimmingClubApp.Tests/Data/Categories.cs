using SwimmingClubApp.Services.Data.Models;

namespace SwimmingClubApp.Tests.Data
{
    public static class Categories
    {
        public static IEnumerable<ProductCategory> CategoriesData()
        {
            var categories = new List<ProductCategory>()
          {

                new ProductCategory()
                {
                    Id = 1,
                    CategoryName = "Some"
                },
                new ProductCategory()
                {
                    Id = 2,
                    CategoryName = "Some1"
                },
                new ProductCategory()
                {
                    Id = 3,
                    CategoryName = "Some2"
                }
            };
            return categories;
        }
    }
}
