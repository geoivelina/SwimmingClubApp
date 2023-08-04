using SwimmingClubApp.Areas.Admin.Services.Swimmer.Models;
using SwimmingClubApp.Services.Entries.Models;

namespace SwimmingClubApp.Areas.Admin.Services.Swimmers
{
    public interface ISwimmerService
    {
        IEnumerable<SwimmerDetailsServiceModel> AllSwimmers();
        IEnumerable<SwimmerDetailsServiceModel> SwimmersToApprove();
        void Approve(int id);
        void Disapprove(int id);

        void Edit(int id, SwimmerEntryServiceModel swimmer);
        void Delete(int swimmerId);

        bool SquadExists(int squadId);
        bool SwimmerExists(int swimmerId);
        SwimmerEntryServiceModel SwimmerDetails(int id);
        IEnumerable<SwimmerSquadServiceModel> AllSquads();

    }
}
