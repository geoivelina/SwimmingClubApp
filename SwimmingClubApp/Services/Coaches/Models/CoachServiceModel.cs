using System.ComponentModel.DataAnnotations;

namespace SwimmingClubApp.Services.Coaches.Models
{
    public class CoachServiceModel
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = null!;

        [Display(Name = "Image URL")]
        public string Image { get; set; } = null!;

        [Display(Name = "Email Address")]
        public string Email { get; set; } = null!;

        [Display(Name = "Job Position")]
        public string JobPosition { get; set; } = null!;

        [Display(Name = "Squad")]
        public int SquadId { get; set; }

    }
}
