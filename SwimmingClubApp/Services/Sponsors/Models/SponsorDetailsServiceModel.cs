using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;

namespace SwimmingClubApp.Services.Sponsors.Models
{
    public class SponsorDetailsServiceModel : SponsorServiceModel, IMapFrom<Sponsor>, IMapTo<Sponsor>
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
