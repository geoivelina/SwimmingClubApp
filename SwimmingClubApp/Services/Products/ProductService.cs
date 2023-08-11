using AutoMapper;
using AutoMapper.QueryableExtensions;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;
using SwimmingClubApp.Services.Data.Models;
using SwimmingClubApp.Services.Products.Models;

namespace SwimmingClubApp.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly SwimmingClubDbContext data;
        private readonly IMapper mapper;

        public ProductService(SwimmingClubDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper;
        }

        //Kenov:Do Not Use AutoMapper in Create& Edit Methods
        public int CreateProduct(string name, string image, decimal price, int productCategoryId, List<ProductSizeServiceModel> sizesList)
        {
            var newProduct = new Product
            {
                Name = name,
                Image = image,
                Price = price,
                ProductCategoryId = productCategoryId,
            };

            foreach (var sizeOption in sizesList)
            {
                var size = this.data.SizeOptions.FirstOrDefault(s => s.Id == sizeOption.Id);
                newProduct.Sizes.Add(new ProductSize
                {
                    SizeOption = size,
                });
            }

            this.data.Products.Add(newProduct);
            this.data.SaveChanges();

            return newProduct.Id;
        }


        public int EditProduct(int id, string name, string image, decimal price, int productCategoryId, List<ProductSizeServiceModel> sizesList)
        {
            var product = this.data.Products.Find(id);

            product.Name = name;
            product.Image = image;
            product.Price = price;
            product.ProductCategoryId = productCategoryId;


            foreach (var sizeOption in sizesList)
            {
                var size = this.data.SizeOptions.FirstOrDefault(s => s.Id == sizeOption.Id);
                product.Sizes.Add(new ProductSize
                {
                    SizeOption = size,
                });
            }

            this.data.SaveChanges();

            return product.Id;
        }

        public ProductServiceModel ProductById(int id)
        {
          return  this.data.Products
                .To<ProductServiceModel>()
                .SingleOrDefault(p => p.Id == id);
        }

        //TODO: FINISH MAPPING HERE
        public ProductDetailsServiceModel ProductDetails(int id)
        {
            
            var productData = this.data.Products
                .Where(p => p.Id == id && p.IsAvtive)
                .Select(p => new ProductDetailsServiceModel
                {
                    Price = p.Price,
                    Id = p.Id,
                    Image = p.Image,
                    Name = p.Name,
                    ProductCategoryName = p.ProductCategory.CategoryName,
                    ProductCategoryId = p.ProductCategoryId,
                    SizesList = p.Sizes.Select(s => new ProductSizeServiceModel
                    {
                        Id = s.SizeOption.Id,
                        Description = s.SizeOption.Description,
                        IsChecked = s.SizeOption.IsChecked
                    }).ToList()
                })
                 .FirstOrDefault();

            return productData;
        }

        public void DeleteProduct(int id)
        {
            var toDelete = this.data.Products.Find(id);
            toDelete.IsAvtive = false;

            this.data.SaveChanges();
        }
        public ProductQueryServiceModel AllProducts(
            string category = null,
            ProductSorting sorting = ProductSorting.Alphabetically,
            int currentPage = 1,
            int productsPerPage = int.MaxValue)
        {
            var queryProduct = this.data.Products.Where(p => p.IsAvtive).AsQueryable();

            if (!string.IsNullOrWhiteSpace(category))
            {
                queryProduct = queryProduct.Where(p => p.ProductCategory.CategoryName == category);
            }

            queryProduct = sorting switch
            {
                ProductSorting.Alphabetically => queryProduct.OrderBy(p => p.Name),
                ProductSorting.Price => queryProduct.OrderBy(p => p.Price),
                _ => queryProduct.OrderByDescending(p => p.Id)
            };

            var products = queryProduct
               .Skip((currentPage - 1) * productsPerPage)
               .Take(productsPerPage)
               .To<ProductServiceModel>()
                .ToList();

            var totalProducts = queryProduct.Count();

            return new ProductQueryServiceModel
            {
                Products = products,
                TotalProducts = totalProducts
            };
        }

        public IEnumerable<ProductCategoryServiceModel> AllProductCategories()
        {
            return this.data
                .ProductCategories
                .To<ProductCategoryServiceModel>()
                .ToList();
        }

        public List<ProductSizeServiceModel> AllSizeOptions()
        {
            return this.data
                .SizeOptions
                .To<ProductSizeServiceModel>()
                .ToList();
        }

        public IEnumerable<string> ProductCategoriesNames()
        {
            var categories = this.data
                  .ProductCategories
                  .Select(c => c.CategoryName)
                  .Distinct()
                  .ToList();
            return categories;
        }

        public bool ProductCategoriesExist(int productCategoryId)
        {
            return this.data.ProductCategories.Any(p => p.Id == productCategoryId);
        }

        public bool ProductExists(int id)
        {
            return this.data.Products.Any(p => p.Id == id);
        }


    }
}
