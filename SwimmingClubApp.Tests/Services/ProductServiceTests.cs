using NUnit.Framework;
using SwimmingClubApp.Data;
using SwimmingClubApp.Services.Products;
using SwimmingClubApp.Test.Mocks;

using static SwimmingClubApp.Tests.Data.Products;

namespace SwimmingClubApp.Tests.Services
{
    public class ProductServiceTests
    {
        private IProductService products;
       

        private void SeedData(SwimmingClubDbContext context)
        {
            context.AddRange(ProductsData);
            context.SaveChanges();
        }

        [Test]
        public void GetAllProductsCategoriesShouldReturnCorrectResult()
        {
            var data = DatabaseMock.Inctance;
            var mapper = MapperMock.Instance;

            SeedData(data);

            var products = new ProductService(data, mapper);

            var result = this.products.AllProducts();

            var expectedResult = ProductsData;

            Assert.That(result, Is.Not.Null);
        }


    }
}
