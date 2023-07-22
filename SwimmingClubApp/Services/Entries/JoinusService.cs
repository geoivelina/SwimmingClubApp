using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Services.Entries.Models;

namespace SwimmingClubApp.Services.Entries
{
    public class JoinusService : IJoinusService
    {
        private readonly SimmingClubDbContext data;

        public JoinusService(SimmingClubDbContext data)
        {
            this.data = data;
        }

        public IEnumerable<SwimmerSquadServiceModel> AllSquads()
        {
            return this.data
                .Squads
                .Select(s => new SwimmerSquadServiceModel
                {
                    Id = s.Id,
                    SquadName = s.SquadName
                })
                .ToList();
        }

        public int CreateEntry(string fullName, int age, string contactPersonName, string relationshipToSwimmer, string address, string? medicalDatails, string swimmingExperience, int squadId)
        {
            var newSwimmer = new Swimmer
            {
                FullName = fullName,
                Age = age,
                ContactPersonName = contactPersonName,
                RelationshipToSwimmer = relationshipToSwimmer,
                Address = address,
                MedicalDatails = medicalDatails,
                SwimmingExperience = swimmingExperience,
                SquadId = squadId
            };

            this.data.Swimmers.Add(newSwimmer);
            this.data.SaveChanges();

            return newSwimmer.Id;
        }

        public IEnumerable<SwimmerServiceModel> SwimmersToApprove()
        {
            return this.data
                .Swimmers
                .Where(s => s.IsApproved == false)
                .Select(s => new SwimmerServiceModel
                {
                    Id = s.Id,
                    Address = s.Address,
                    Age = s.Age,
                    FullName = s.FullName,
                    PhoneNumber = s.PhoneNumber,
                    Email = s.Email,
                    ContactPersonName = s.ContactPersonName,
                    RelationshipToSwimmer = s.RelationshipToSwimmer,
                    MedicalDatails = s.MedicalDatails,
                    SwimmingExperience = s.SwimmingExperience,
                    Squad = s.Squad.SquadName
                });
        }
        public bool SquadExists(int squadId)
        {
            return this.data.Squads.Any(s => s.Id == squadId);
        }

        public bool SwimmerExists(int id)
        {
            return this.data.Swimmers.Any(s => s.Id == id);
        }

        public int SwimmerById(int swimmerId)
        {
            return this.data.Swimmers
                .Where(s => s.Id == swimmerId)
                .Select(s => s.Id)
                .FirstOrDefault();
        }

        public IEnumerable<SwimmerServiceModel> AllSwimmers()
        {
            return this.data.Swimmers
                .Select(s => new SwimmerServiceModel
                {
                    Id = s.Id,
                    FullName = s.FullName,
                    Age = s.Age,
                    Address = s.Address,
                    ContactPersonName = s.ContactPersonName,
                    Email = s.Email,
                    MedicalDatails = s.MedicalDatails,
                    PhoneNumber = s.PhoneNumber,
                    RelationshipToSwimmer = s.RelationshipToSwimmer,
                    Squad = s.Squad.SquadName,
                    SwimmingExperience = s.SwimmingExperience,
                    IsApproved = s.IsApproved
                });
        }
    }
}
