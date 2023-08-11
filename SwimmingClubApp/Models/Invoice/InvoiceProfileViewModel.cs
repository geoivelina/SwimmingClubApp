using SwimmingClubApp.Infrastructure.Mapping;
using SwimmingClubApp.Services.Invoices.Models;

namespace SwimmingClubApp.Models.Invoice
{
    public class InvoiceProfileViewModel
    {
        public int Id { get; set; }
        public DateTime IssuedOn { get; set; }

        public decimal TotalSum { get; set; }
    }
}
