using SwimmingClubApp.Services.Entries.Models;

namespace SwimmingClubApp.Services.Entries
{
    public interface IJoinusService
    {
        IEnumerable<SwimmerSquadServiceModel> AllSquads();
        bool SquadExists(int squadId);
        int CreateEntry(string fullName,
                int age,
                string contactPersonName,
                string relationshipToSwimmer,
                string address,
                string? medicalDatails,
                string swimmingExperience,
                int squadId);

        IEnumerable<SwimmerServiceModel> SwimmersToApprove();
        IEnumerable<SwimmerServiceModel> AllSwimmers();
        int SwimmerById(int swimmerId);
        bool SwimmerExists(int id);
    }
}
