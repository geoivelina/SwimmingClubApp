using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;

namespace SwimmingClubApp.Services.Coaches.Models
{
    public class CoachDetailsServiceModel : CoachServiceModel, IMapFrom<Coach>, IMapTo<Coach>
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}
