using SwimmingClubApp.Services.Orders.Models;

namespace SwimmingClubApp.Services.Orders
{
    public interface IOrderService
    {
        int CreateOrder(OrderServiceModel order);
        IEnumerable<OrderServiceModel> All();
    }
}
