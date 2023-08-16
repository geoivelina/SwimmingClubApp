using AutoMapper;
using AutoMapper.QueryableExtensions;
using MyTested.AspNetCore.Mvc.Utilities.Extensions;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Services.Data.Models;
using SwimmingClubApp.Services.Orders;
using SwimmingClubApp.Services.Orders.Models;

namespace SwimmingClubApp.Services.Invoices.Models
{
    public class InvoiceService : IInvoiceService
    {
        private readonly SwimmingClubDbContext data;
        private readonly IOrderService orders;
        private readonly IMapper mapper;

        public InvoiceService(SwimmingClubDbContext data, IMapper mapper, IOrderService orders)
        {
            this.data = data;
            this.mapper = mapper;
            this.orders = orders;
        }

        public int CreateInvoice(string clientId)
        {
            var invoice = new Invoice
            {
                IssuedOn = DateTime.UtcNow,
                ClientId = clientId,

            };

            //consumer method
            this.orders.SetOrdersToInvoice(invoice);

            invoice.Orders.ForEach(o => this.orders.FinishOrder(o.Id));

            this.data.Invoices.Add(invoice);
            this.data.SaveChanges();

            return invoice.Id;
        }

        //TODO: CHECK MAPPING HERE
        public IEnumerable<InvoiceServiceModel> All()
        {
            var invoices = this.data
                .Invoices
                .ProjectTo<InvoiceServiceModel>(this.mapper.ConfigurationProvider);
                
            return invoices;
        }

        public User ClientInfo(string id)
        {
            return this.data.Users.Find(id); ;
        }


        //TODO: CHECK MAPPING HERE
        public IEnumerable<InvoiceServiceModel> AllByClientId(string clientId)
        {
            return this.data.Invoices
                 .Where(i => i.ClientId == clientId)
                 .ProjectTo<InvoiceServiceModel>(this.mapper.ConfigurationProvider);
        }

    }
}
