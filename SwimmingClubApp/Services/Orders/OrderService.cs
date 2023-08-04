using AutoMapper;
using AutoMapper.QueryableExtensions;
using SwimmingClubApp.Data;
using SwimmingClubApp.Services.Data.Models;
using SwimmingClubApp.Services.Orders.Models;

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

        public IEnumerable<OrderServiceModel> All()
        {
            return this.data.Orders.ProjectTo<OrderServiceModel>(this.mapper.ConfigurationProvider);
        }

        public int CreateOrder(OrderServiceModel order)
        {
            var newOrder = this.mapper.Map<Order>(order);
            newOrder.Status = this.data.OrderStatuses.SingleOrDefault(o => o.Name == "Active");
            newOrder.IssuedOn = DateTime.UtcNow;
            //new Order
            //{
            //    IssuedOn = order.IssuedOn,
            //    Quantity = order.Quantity,
            //    ProductId = order.ProductId,
            //    SizeId = order.SizeId,
            //    StatusId = order.StatusId,
            //};

            this.data.Orders.Add(newOrder);
            this.data.SaveChanges();

            return newOrder.Id;
        }
    }
}
