using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.Coach;

namespace SwimmingClubApp.Models.About
{
    public class AddCoachFormModel
    {
        [Required]
        [StringLength(FullNameMaxLength, MinimumLength = FullNameMinLength, ErrorMessage ="The Full Name feild must be between {2} and {1} symbols")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = null!;

        [Required]
        [Display(Name = "Image URL")]
        [Url]
        public string Image { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Display(Name = "Squad")]
        public int SquadId { get; set; }

        public IEnumerable<CoachSquadViewModel> Squads { get; set; } = new List<CoachSquadViewModel>();

    }
}
