namespace SwimmingClubApp.Services.Products.Models
{
    public class ProductQueryServiceModel
    {
        public int TotalProducts { get; set; }
        public IEnumerable<ProductSizeServiceModel> Sizes { get; set; } = new List<ProductSizeServiceModel>();

        public IEnumerable<ProductServiceModel> Products { get; set; } = new List<ProductServiceModel>();
    }
}
