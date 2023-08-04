using SwimmingClubApp.Services.Data.Models;

namespace SwimmingClubApp.Data.Models
{
    public class ProductSize
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;

        public int SizeId { get; set; }
        public virtual SizeOption SizeOption { get; set; } = null!;

    }
}
