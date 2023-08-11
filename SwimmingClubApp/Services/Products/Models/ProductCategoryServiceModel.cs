using SwimmingClubApp.Infrastructure.Mapping;
using SwimmingClubApp.Services.Data.Models;

namespace SwimmingClubApp.Services.Products.Models
{
    public class ProductCategoryServiceModel : IMapFrom<ProductCategory>, IMapTo<ProductCategory>
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
