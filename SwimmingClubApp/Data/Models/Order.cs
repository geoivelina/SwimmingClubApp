using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Services.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime IssuedOn { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int SizeId { get; set; }
        public string IssuerId { get; set; } = null!;
        public User Issuer { get; set; } = null!;
        public int StatusId { get; set; }
        public OrderStatus Status { get; set; }
    }
}
