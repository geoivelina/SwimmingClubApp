using SwimmingClubApp.Services.Data.Models;

namespace SwimmingClubApp.Data.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime IssuedOn { get; set; }
        public string ClientId { get; set; } = null!;
        public User Client { get; set; } = null!;
        public IEnumerable<Order> Orders { get; set; } = new List<Order>();
    }
}
