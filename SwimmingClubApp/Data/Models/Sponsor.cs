using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.Sponsor;

namespace SwimmingClubApp.Data.Models
{
    public class Sponsor
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLenth)]
        public string Name { get; set; } = null!;

        [Required]
        public string Logo { get; set; } = null!;
        [Required]
        public string Link { get; set; } = null!;

        public bool IsAvtive { get; set; } = true;
    }
}
