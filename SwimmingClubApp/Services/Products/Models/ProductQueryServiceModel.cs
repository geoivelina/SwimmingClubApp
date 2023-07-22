namespace SwimmingClubApp.Services.Products.Models
{
    public class ProductQueryServiceModel
    {
        public int TotalProducts { get; set; }
        public IEnumerable<ProductServiceModel> Products { get; set; } = new List<ProductServiceModel>();
    }
}
