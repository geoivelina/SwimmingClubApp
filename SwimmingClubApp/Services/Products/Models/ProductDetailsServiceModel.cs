using AutoMapper;
using SwimmingClubApp.Infrastructure.Mapping;
using SwimmingClubApp.Services.Data.Models;

namespace SwimmingClubApp.Services.Products.Models
{
    public class ProductDetailsServiceModel :  IMapFrom<ProductServiceModel>, IMapTo<ProductServiceModel>, IMapFrom<Product> 
        //, IHaveCustomMappings
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Image { get; set; } = null!;
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; } = null!;
        public List<ProductSizeServiceModel> SizesList { get; set; } = new List<ProductSizeServiceModel>();

        //public void CreateMappings(IProfileExpression configuration)
        //{
        //    configuration
        //      .CreateMap<Product, ProductDetailsServiceModel>()
        //      .ForMember(des => des.ProductCategoryName, opt => opt.MapFrom(origin => new ProductDetailsServiceModel
        //      {
        //          ProductCategoryName= origin.ProductCategory.CategoryName
        //      }))
        //      .ForMember(des => des.SizesList, opt => opt.MapFrom(s => s.Sizes))
        //      .ReverseMap();
        //}
    }
}
