
using SwimmingClubApp.Services.Coaches.Models;

namespace SwimmingClubApp.Services.Coaches
{
    public interface ICoachService
    {
        bool SquadExists(int squadId);
        bool CoachExists(int coachId);
        CoachDetailsServiceModel CoachDetails(int coachId);
        int CreateCoach(string fullName, string image, string email, int squadId, string jobPosition);
        void EditCoach(int id, CoachFormModel coach);
        void DeleteCoach(int coachId);
        IEnumerable<CoachListingServiceModel> AllCoaches();
        IEnumerable<CoachSquadServiceModel> AllSquads();
      
    }
}
