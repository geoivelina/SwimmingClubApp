namespace SwimmingClubApp.Services.Orders.Models
{
    public class OrderCartViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = null!;
        public string SizeName { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Sum { get; set; }
    }
}
