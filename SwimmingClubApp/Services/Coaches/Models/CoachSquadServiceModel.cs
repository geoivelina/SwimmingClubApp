using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;

namespace SwimmingClubApp.Services.Coaches.Models
{
    public class CoachSquadServiceModel : IMapFrom<Squad>, IMapTo<Squad>
    {
        public int Id { get; set; }
        public string SquadName { get; set; } = null!;
    }
}
