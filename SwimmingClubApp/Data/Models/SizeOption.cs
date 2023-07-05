using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.SizeOption;

namespace SwimmingClubApp.Data.Models
{
    public class SizeOption
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(SizeOptionDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public bool IsChecked { get; set; }
        public IEnumerable<ProductSize> Products { get; set; } = new List<ProductSize>();

    }
}
