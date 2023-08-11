using SwimmingClubApp.Infrastructure.Mapping;
using SwimmingClubApp.Services.Orders.Models;

namespace SwimmingClubApp.Models.ClubShop
{
    public class ProductOrderInputModel 
    {
        public int ProductId { get; set; }
        public int SizeId { get; set; }
        public int Quantity { get; set; }
    }
}
