using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;

namespace SwimmingClubApp.Services.Orders.Models
{
    public class OrderStatusServiceModel :IMapFrom<OrderStatus>
    {
        public int Id { get; set; }
        public string Name { get; set; } = null;
    }
}
