using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.Squad;

namespace SwimmingClubApp.Data.Models
{
    public class Squad
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(SquadNameMaxLength)]
        public string SquadName { get; set; } = null!;
        public IEnumerable<Coach> Coaches { get; set; } = new List<Coach>();
    }
}
