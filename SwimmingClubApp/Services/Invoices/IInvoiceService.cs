using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Services.Data.Models;
using SwimmingClubApp.Services.Invoices.Models;

namespace SwimmingClubApp.Services.Invoices
{
    public interface IInvoiceService
    {
        int CreateInvoice(string clientId);
        User ClientInfo(string id);
        IEnumerable<InvoiceServiceModel> All();
        IEnumerable<InvoiceServiceModel> AllByClientId(string clientId);

    }
}
