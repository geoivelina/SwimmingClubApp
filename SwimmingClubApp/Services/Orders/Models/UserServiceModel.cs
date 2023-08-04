using Microsoft.AspNetCore.Identity;

namespace SwimmingClubApp.Services.Orders.Models
{
    public class UserServiceModel:IdentityUser
    {
        public string UserFullName { get; set; } = null!;
        public List<OrderServiceModel> Orders { get; set; } = new List<OrderServiceModel>();
    }
}
