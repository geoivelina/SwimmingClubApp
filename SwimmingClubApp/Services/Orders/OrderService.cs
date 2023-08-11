using AutoMapper;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Services.Data.Models;
using SwimmingClubApp.Services.Invoices.Models;
using SwimmingClubApp.Services.Orders.Models;
using SwimmingClubApp.Services.Products.Models;

namespace SwimmingClubApp.Services.Orders
{
    public class OrderService : IOrderService
    {
        private readonly SwimmingClubDbContext data;
        private readonly IMapper mapper;

        public OrderService(SwimmingClubDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper;
        }


        //TODO: FINISH MAPPING HERE
        public IEnumerable<OrderServiceModel> All()
        {
            return this.data.Orders
                .Select(o => new OrderServiceModel
                {
                    Id = o.Id,
                    IssuedOn = o.IssuedOn,
                    Quantity = o.Quantity,
                    ProductId = o.ProductId,
                    Product = new ProductServiceModel
                    {
                        Id = o.ProductId,
                        Name = o.Product.Name,
                        Price = o.Product.Price
                    },
                    SizeId = o.SizeId,
                    IssuerId = o.IssuerId,
                    StatusId = o.StatusId,
                });
        }

        public int CreateOrder(OrderServiceModel order)
        {

            var newOrder = new Order
            {
                IssuedOn = order.IssuedOn,
                Quantity = order.Quantity,
                ProductId = order.ProductId,
                SizeId = order.SizeId,
                StatusId = order.StatusId,
                IssuerId = order.IssuerId,
            };

            newOrder.Status = this.data.OrderStatuses.SingleOrDefault(o => o.Name == "Active");
            newOrder.IssuedOn = DateTime.UtcNow;


            this.data.Orders.Add(newOrder);
            this.data.SaveChanges();

            return newOrder.Id;
        }

        public int FinishOrder(int orderId)
        {
            var order = this.data.Orders.Find(orderId);

            order.Status = this.data.OrderStatuses.SingleOrDefault(o => o.Id == 2);

            this.data.Update(order);

            this.data.SaveChanges();

            return order.Id;
        }

        public Order OrderById(int orderId)
        {
            return this.data.Orders.Find(orderId);
        }
        public bool OrderExists(int orderId)
        {
            return this.data.Orders.Any(o => o.Id == orderId);
        }

        public void SetOrdersToInvoice(Invoice invoice)
        {
            invoice.Orders = this.data.Orders
                .Where(o => o.IssuerId == invoice.ClientId && o.StatusId == 1)
                .ToList();
        }
        
    }
}
