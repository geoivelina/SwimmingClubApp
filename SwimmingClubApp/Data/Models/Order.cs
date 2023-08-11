using SwimmingClubApp.Data.Models;
using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.Order;

namespace SwimmingClubApp.Services.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        
        [Required]
        public DateTime IssuedOn { get; set; }

        [Required]
        [MaxLength(QuantityMaxAmount)]
        public int Quantity { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        [Required]
        public int SizeId { get; set; }

        [Required]
        public string IssuerId { get; set; } = null!;
        public User Issuer { get; set; } = null!;

        [Required]
        public int StatusId { get; set; }
        public OrderStatus Status { get; set; }
    }
}
