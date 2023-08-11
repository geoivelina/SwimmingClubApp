using SwimmingClubApp.Infrastructure.Mapping;
using SwimmingClubApp.Services.Invoices.Models;
using SwimmingClubApp.Services.Orders.Models;

namespace SwimmingClubApp.Models.Invoice
{
    public class InvoiceDetailsViewModel:IMapFrom<InvoiceServiceModel>
    {
        public int Id { get; set; }
        public DateTime IssuedOn { get; set; }
        public string ClientName { get; set; } = null!;

        public IEnumerable<InvoiceDetailsOrderViewModel> Orders { get; set; } = new List<InvoiceDetailsOrderViewModel>();
    }
}
