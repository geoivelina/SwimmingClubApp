using SwimmingClubApp.Infrastructure.Mapping;
using SwimmingClubApp.Services.Data.Models;
using SwimmingClubApp.Services.Products.Models;
using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.Order;

namespace SwimmingClubApp.Services.Orders.Models
{
    public class OrderServiceModel: IMapFrom<Order>, IMapTo<Order>
    {
        public int Id { get; set; }

        [Display(Name ="Issued On")]
        public DateTime IssuedOn { get; set; }

        [Required]
        [Range(QuantityMinAmount, QuantityMaxAmount, ErrorMessage = "The product quantity must be between {1} and {2}")]
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public ProductServiceModel Product { get; set; } = null!;
        public int SizeId { get; set; }
        public string IssuerId { get; set; } = null!;
        public UserServiceModel Issuer { get; set; } = null!;
        public int StatusId { get; set; }
        public OrderStatusServiceModel Status { get; set; }
    }
}
