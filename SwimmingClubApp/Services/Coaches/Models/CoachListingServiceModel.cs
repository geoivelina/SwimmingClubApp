using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;

namespace SwimmingClubApp.Services.Coaches.Models
{
    public class CoachListingServiceModel :IMapFrom<Coach>, IMapTo<Coach>
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;

        public string Image { get; set; } = null!;

        public string Email { get; set; } = null!;
        public string JobPosition { get; set; } = null!;

        public string Squad { get; set; } = null!;
        public bool IsAvtive { get; set; } = true;
    }
}
