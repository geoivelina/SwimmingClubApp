using SwimmingClubApp.Infrastructure.Mapping;
using SwimmingClubApp.Services.Orders.Models;

namespace SwimmingClubApp.Models.Invoice
{
    public class InvoiceDetailsOrderViewModel : IMapFrom<OrderServiceModel>
    {
        public string ProductName { get; set; } = null!;
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
    }
}
