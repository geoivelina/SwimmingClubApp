using AutoMapper;
using SwimmingClubApp.Data;
using SwimmingClubApp.Services.Data.Models;
using SwimmingClubApp.Services.Products;
using SwimmingClubApp.Services.Products.Models;
using SwimmingClubApp.Test.Mocks;
using static SwimmingClubApp.Tests.Data.Categories;
using static SwimmingClubApp.Tests.Data.Products;
using static SwimmingClubApp.Tests.Data.Sizes;


namespace SwimmingClubApp.Tests.Services
{
    public class ProductServiceTests
    {
        private IProductService products;
        protected SwimmingClubDbContext data;
        protected IMapper mapper;

        [SetUp]
        public void Setup()
        {
            this.data = DatabaseMock.Inctance;
            this.mapper = MapperMock.Instance;
            this.products = new ProductService(data, mapper);
        }

        private void SeedData(SwimmingClubDbContext context)
        {
            context.AddRange(ProductsData());
            context.AddRange(CategoriesData());
            context.AddRange(SizesData());
            context.SaveChanges();
        }

        //[Test]
        //public void ProductByIdWithCorrectIdShouldReturnProductDetails()
        //{
        //    SeedData(data);
        //    data.SaveChanges();

        //    var result = products.ProductById(1);

        //    Assert.That(result, Is.Not.Null);
        //    Assert.That(result.Name, Is.EqualTo("Swimming Hat"));
        //    Assert.That(result, Is.TypeOf<ProductServiceModel>());
        //}

        [Test]
        public void AllSizeOptionsWithDataShouldReturnAllSizesInDb()
        {
            SeedData(data);
            data.SaveChanges();

            var result = products.AllSizeOptions();

            Assert.That( result, Is.Not.Null );
            Assert.That(result.Count(), Is.EqualTo(3));
        }

        [Test]
        public void AllSizeOptionsWithoutDataShouldReturnReturn0()
        {
            var result = products.AllSizeOptions();

            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public void AllProductsCategoriesWithDataShouldReturnAllCategoriesFromDb()
        {
            SeedData(data);
            data.SaveChanges();

            var result = products.AllProductCategories();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(3));
        }

        [Test]
        public void AllProductsCategoriesWithoutDataShouldReturn0()
        {
            var result = products.AllProductCategories();

            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public void ProductCategoriesNamesShouldReturnListOfCategoryNames()
        {
            SeedData(data);
            data.SaveChanges();

            var result = products.ProductCategoriesNames();

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<List<string>>());
            Assert.That(result.Count(), Is.EqualTo(3));
        }

        [Test]
        public void ProductCategoriesNamesWithNoDataShouldReturn0()
        {
            var result = products.ProductCategoriesNames();

            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public void ProductCategoriesExistWithCorrectIdShouldReturnTrue()
        {
            SeedData(data);
            data.SaveChanges();

            var result = products.ProductCategoriesExist(1);

            Assert.That(result, Is.True);
        }

        [Test]
        public void ProductCategoriesExistWithWrongIdShouldReturnFalse()
        {
            SeedData(data);
            data.SaveChanges();

            var result = products.ProductCategoriesExist(8);

            Assert.That(result, Is.False);
        }

        [Test]
        public void ProductExsistWithCorrectIdShouldReturnTrue()
        {
            SeedData(data);
            data.SaveChanges();

            var result = products.ProductExists(1);

            Assert.That(result, Is.True);
        }

        [Test]
        public void ProductExsistWithWrongIdShouldReturnFalse()
        {
            SeedData(data);
            data.SaveChanges();

            var result = products.ProductExists(7);

            Assert.That(result, Is.False);
        }

        [TearDown]
        public void TearDown() => this.data.Dispose();
    }
}
