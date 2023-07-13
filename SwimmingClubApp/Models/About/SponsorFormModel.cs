using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.Sponsor;

namespace SwimmingClubApp.Models.About
{
    public class SponsorFormModel
    {
        [Required]
        [StringLength(NameMaxLenth, MinimumLength = NameMinLenth, ErrorMessage = "Sponsor Name must be between {2} and {1} symbols")]
        public string Name { get; set; } = null!;

        [Required]
        public string Logo { get; set; } = null!;

        [Required]
        [Url]
        [Display(Name = "Home Page Link")]
        public string Link { get; set; } = null!;
    }
}
