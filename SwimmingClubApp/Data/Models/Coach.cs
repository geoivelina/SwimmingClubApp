using SwimmingClubApp.Models.About;
using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.Coach;

namespace SwimmingClubApp.Data.Models
{
    public class Coach
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(FullNameMaxLength)]
        public string FullName { get; set; } = null!;

        [Required]
        public string Image { get; set; } = null!;

        [Required]
        public int SquadId { get; set; }
        public Squad Squads { get; set; } = null!;

        [Required]
        [MaxLength(EmailMaxLength)]
        public string Email { get; set; } = null!;
    }
}
