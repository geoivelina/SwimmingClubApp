using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.News;

namespace SwimmingClubApp.Models.About
{
    public class AddNewsFormModel
    {

        [Required]
        [StringLength(TitleMaxLenth, MinimumLength = TitleMinLenth, ErrorMessage = "The Full Name feild must be between {2} and {1} symbols")]
        public string Title { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        [StringLength(DescriptionMaxLenth, MinimumLength = DescriptionMinLenth, ErrorMessage = "The Full Name feild must be between {2} and {1} symbols")]
        public string Desctioption { get; set; } = null!;
    }
}
