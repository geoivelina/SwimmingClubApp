using Microsoft.CodeAnalysis.Differencing;
using SwimmingClubApp.Models.About;
using SwimmingClubApp.Services.Coaches.Models;

namespace SwimmingClubApp.Services.Coaches
{
    public interface ICoachService
    {
        bool SquadExists(int squadId);
        bool CoachExists(int coachId);
        CoachDetailsServiceModel CoachDetails(int coachId);
        int CreateCoach(string fullName, string image, string email, int squadId, string jobPosition);
        void Edit(int id, CoachFormModel coach);
        void Delete(int coachId);
        IEnumerable<CoachListingServiceModel> AllCoaches();
        IEnumerable<CoachSquadServiceModel> AllSquads();
      
    }
}
