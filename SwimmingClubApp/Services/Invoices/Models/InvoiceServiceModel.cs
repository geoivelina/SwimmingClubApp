using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;
using SwimmingClubApp.Services.Orders.Models;
using SwimmingClubApp.Services.Users;

namespace SwimmingClubApp.Services.Invoices.Models
{
    public class InvoiceServiceModel : IMapFrom<Invoice>
    {
        public int Id { get; set; }
        public DateTime IssuedOn { get; set; }
        public string ClientId { get; set; } = null!;
        public UserServiceModel Client { get; set; } = null!;
        public IEnumerable<OrderServiceModel> Orders { get; set; } = new List<OrderServiceModel>();
    }
}
