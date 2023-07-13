using SwimmingClubApp.Services.Sponsors.Models;

namespace SwimmingClubApp.Services.Sponsors
{
    public interface ISponsorService
    {

        int CreateSponsor(string name, string link, string logo);
        IEnumerable<SponsorServiceModel> AllSponsors();
    }
}
