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
        void EditSwimmer(int id,
           string fullName,
           int age,
           string email,
           string address,
           string phoneNumber,
           string contactPerson,
           string medicalDetails,
           string relationship,
           string swimmingExperience,
           int squad);
        void DeleteSwimmer(int id);
        
        int SwimmerById(int swimmerId);
        bool SwimmerExists(int id);
        SwimmerSquadServiceModel SquadName(int id);
    }
}
