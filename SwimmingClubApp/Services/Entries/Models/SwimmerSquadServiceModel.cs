using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;

namespace SwimmingClubApp.Services.Entries.Models
{
    public class SwimmerSquadServiceModel :IMapFrom<Squad>, IMapTo<Squad>
    {
        public int Id { get; set; }
        public string SquadName { get; set; } = null!;
    }
}
