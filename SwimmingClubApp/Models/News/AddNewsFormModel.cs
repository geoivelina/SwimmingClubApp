using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.News;

namespace SwimmingClubApp.Models.News
{
    public class AddNewsFormModel
    {

        [Required]
        [StringLength(TitleMaxLenth, MinimumLength = TitleMinLenth, ErrorMessage = "The Title feild must be between {2} and {1} symbols")]
        public string Title { get; set; } = null!;

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public string Image { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLenth, MinimumLength = DescriptionMinLenth, ErrorMessage = "The Description feild must be between {2} and {1} symbols")]
        public string Desctioption { get; set; } = null!;
    }
}
