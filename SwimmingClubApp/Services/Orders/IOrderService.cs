using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Services.Data.Models;
using SwimmingClubApp.Services.Orders.Models;

namespace SwimmingClubApp.Services.Orders
{
    public interface IOrderService
    {
        int CreateOrder(OrderServiceModel order);
        IEnumerable<OrderServiceModel> All();
        void SetOrdersToInvoice(Invoice invoice);
        int FinishOrder(int orderId);
        Order OrderById(int orderId);
        bool OrderExists(int orderId);
    }
}
