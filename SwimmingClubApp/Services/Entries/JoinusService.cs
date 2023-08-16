using AutoMapper;
using AutoMapper.QueryableExtensions;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;
using SwimmingClubApp.Services.Data.Models;
using SwimmingClubApp.Services.Entries.Models;

namespace SwimmingClubApp.Services.Entries
{
    public class JoinusService : IJoinusService
    {
        private readonly SwimmingClubDbContext data;
        private readonly IMapper mapper;

        public JoinusService(SwimmingClubDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper;
        }

        public int CreateEntry(string fullName,
                int age,
                string email,
                string phoneNumber,
                string contactPersonName,
                string relationshipToSwimmer,
                string address,
                string? medicalDatails,
                string swimmingExperience,
                int squadId)
        {
            var newSwimmer = new Swimmer
            {
                FullName = fullName,
                Age = age,
                ContactPersonName = contactPersonName,
                RelationshipToSwimmer = relationshipToSwimmer,
                Address = address,
                MedicalDatails = medicalDatails,
                Email = email,
                PhoneNumber = phoneNumber,
                SwimmingExperience = swimmingExperience,
                SquadId = squadId
            };
            this.data.Swimmers.Add(newSwimmer);
            this.data.SaveChanges();

            return newSwimmer.Id;
        }

        public void EditSwimmer(
            int id,
            string fullName,
            int age,
            string email,
            string address,
            string phoneNumber,
            string contactPerson,
            string medicalDetails,
            string relationship,
            string swimmingExperience,
            int squad
            )
        {
            var toEdit = this.data.Swimmers.Find(id);

            if (toEdit == null)
            {
                return;
            }
            toEdit.FullName = fullName;
            toEdit.Age = age;
            toEdit.Email = email;
            toEdit.Address = address;
            toEdit.PhoneNumber = phoneNumber;
            toEdit.ContactPersonName = contactPerson;
            toEdit.MedicalDatails = medicalDetails;
            toEdit.RelationshipToSwimmer = relationship;
            toEdit.SwimmingExperience = swimmingExperience;
            toEdit.SquadId = squad;

            this.data.SaveChanges();
        }

        public void DeleteSwimmer(int id)
        {
            var toDelete = this.data.Swimmers.Find(id);
            toDelete.IsActive = false;

            this.data.SaveChanges();
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
                .Where(s => s.Id == swimmerId && s.IsActive)
                .Select(s => s.Id)
                .FirstOrDefault();
        }
       
       
        public IEnumerable<SwimmerSquadServiceModel> AllSquads()
        {
            return this.data
                .Squads
                .ProjectTo<SwimmerSquadServiceModel>(this.mapper.ConfigurationProvider)
                .ToList();
        }


        //TODO:  Menus for all Squads and their participants 
        public SwimmerSquadServiceModel SquadName(int id)
        {
            return this.data.Squads
                .Where(s => s.Id == id)
                .To<SwimmerSquadServiceModel>()
                .FirstOrDefault();
        }

      
    }
}
