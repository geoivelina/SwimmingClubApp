namespace SwimmingClubApp.Models.ClubShop
{
    public class ProductDetailsViewModel:ProductViewModel
    {
        public int ProductCategoryId { get; set; }
        public IEnumerable<ProductSizeViewModel> SizeOptions { get; set; } = new List<ProductSizeViewModel>();
    }
}
