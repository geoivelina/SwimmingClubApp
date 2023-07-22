namespace SwimmingClubApp.Services.Products.Models
{
    public class ProductDetailsServiceModel : ProductServiceModel
    {
        public int ProductCategoryId { get; set; }
        public string Category { get; set; } = null!;
        public List<ProductSizeServiceModel> SizesList { get; set; } = new List<ProductSizeServiceModel>();
    }
}
