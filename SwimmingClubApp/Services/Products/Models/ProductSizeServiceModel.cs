using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;

namespace SwimmingClubApp.Services.Products.Models
{
    public class ProductSizeServiceModel :IMapFrom<SizeOption>
    {
        public int Id { get; set; }
        public bool IsChecked { get; set; }
        public string Description { get; set; } = null!;

    }
}
