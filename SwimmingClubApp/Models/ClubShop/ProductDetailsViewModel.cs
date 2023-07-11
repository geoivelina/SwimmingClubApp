

namespace SwimmingClubApp.Models.ClubShop
{
    public class ProductDetailsViewModel 
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Image { get; set; } = null!;
        public decimal Price { get; set; }

        public int ProductCategoryId { get; set; }
        
       // public IEnumerable<ProductSizeViewModel> SizeOptions { get; set; } = new List<ProductSizeViewModel>();
    }
}
