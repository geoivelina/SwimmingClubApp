using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Infrastructure;
using SwimmingClubApp.Models.Invoice;
using SwimmingClubApp.Services.Invoices;

namespace SwimmingClubApp.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService invoices;
        private readonly IMapper mapper;

        public InvoiceController(IInvoiceService invoice, IMapper mapper)
        {
            this.invoices = invoice;
            this.mapper = mapper;
        }

        //TODO: FINISH MAPPING HERE
        [HttpGet]
        public IActionResult Details(int id)
        {
            var userId = this.User.GetId();
            var client = this.invoices.ClientInfo(userId);


            var invoiceData = this.invoices
                    .All()
                    .Where(i => i.Id == id)
                    .FirstOrDefault();
            var invoice = this.mapper.Map<InvoiceDetailsViewModel>(invoiceData);

            return View(invoice);
        }

        [HttpGet]
        public IActionResult Profile()
        {
            var userId = this.User.GetId();
            var invoicesByUser = this.invoices.AllByClientId(userId).ToList();

            var ivoices = new List<InvoiceProfileViewModel>(); 
            foreach (var item in invoicesByUser)
            {
                var invoice = this.mapper.Map<InvoiceProfileViewModel>(item);
                ivoices.Add(invoice);
            }

            return View(ivoices);
        }
        public IActionResult InvoicesByClient()
        {
            return View();
        }
    }
}
