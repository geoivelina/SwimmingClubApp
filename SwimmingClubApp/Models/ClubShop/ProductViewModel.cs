namespace SwimmingClubApp.Models.ClubShop
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Image { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
