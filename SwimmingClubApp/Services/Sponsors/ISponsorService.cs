using SwimmingClubApp.Models.About;
using SwimmingClubApp.Services.Sponsors.Models;

namespace SwimmingClubApp.Services.Sponsors
{
    public interface ISponsorService
    {
        bool SponsorExists(int id);
        void Edit(int id, SponsorFormModel sponsor);
        void DeleteSponsor(int id);
        SponsorDetailsServiceModel Details(int id);
        int CreateSponsor(string name, string link, string logo);
        IEnumerable<SponsorDetailsServiceModel> AllSponsors();
    }
}
