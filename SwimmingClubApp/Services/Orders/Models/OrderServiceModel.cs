using SwimmingClubApp.Services.Products.Models;

namespace SwimmingClubApp.Services.Orders.Models
{
    public class OrderServiceModel
    {
        public int Id { get; set; }
        public DateTime IssuedOn { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public ProductServiceModel Product { get; set; } = null!;
        public int SizeId { get; set; }
        public ProductSizeServiceModel Size { get; set; } = null!;
        public string IssuerId { get; set; } = null!;
        public UserServiceModel Issuer { get; set; } = null!;
        public int StatusId { get; set; }
        public OrderStatusServiceModel Status { get; set; }
    }
}
