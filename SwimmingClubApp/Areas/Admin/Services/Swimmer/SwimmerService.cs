using SwimmingClubApp.Areas.Admin.Services.Swimmer.Models;
using SwimmingClubApp.Data;
using SwimmingClubApp.Services.Entries.Models;

namespace SwimmingClubApp.Areas.Admin.Services.Swimmers
{
    public class SwimmerService : ISwimmerService
    {
        private readonly SwimmingClubDbContext data;

        public SwimmerService(SwimmingClubDbContext data)
        {
            this.data = data;
        }


        public IEnumerable<SwimmerDetailsServiceModel> AllSwimmers()
        {
            return this.data.Swimmers
                .Select(s => new SwimmerDetailsServiceModel
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
                    SquadId = s.SquadId,
                    SquadName = s.Squad.SquadName,
                    SwimmingExperience = s.SwimmingExperience,
                    IsApproved = s.IsApproved
                });
        }
        public IEnumerable<SwimmerDetailsServiceModel> AllApprovedSwimmers()
        {
            return this.data.Swimmers
                .Where(s => s.IsApproved == true)
                .Select(s => new SwimmerDetailsServiceModel
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
                    SquadId = s.SquadId,
                    SquadName = s.Squad.SquadName,
                    SwimmingExperience = s.SwimmingExperience,
                    IsApproved = s.IsApproved
                });
        }


        public IEnumerable<SwimmerDetailsServiceModel> AllDiaspprovedSwimmers()
        {
            return this.data.Swimmers
                 .Where(s => s.IsApproved == false)
                 .Select(s => new SwimmerDetailsServiceModel
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
                     SquadId = s.SquadId,
                     SquadName = s.Squad.SquadName,
                     SwimmingExperience = s.SwimmingExperience,
                     IsApproved = s.IsApproved
                 });
        }

        public void Approve(int id)
        {
            var toApprove = this.data.Swimmers.Find(id);
            toApprove.IsApproved = true;

            this.data.SaveChanges();
        }

        public void Disapprove(int id)
        {
            var toDisapprove = this.data.Swimmers.Find(id);
            toDisapprove.IsApproved = false;

            this.data.SaveChanges();
        }

        public void Edit(int id, SwimmerEntryServiceModel swimmer)
        {
            var toEdit = this.data.Swimmers.Find(id);

            toEdit.FullName = swimmer.FullName;
            toEdit.Age = swimmer.Age;
            toEdit.Email = swimmer.Email;
            toEdit.Address = swimmer.Address;
            toEdit.PhoneNumber = swimmer.PhoneNumber;
            toEdit.MedicalDatails = swimmer.MedicalDatails;
            toEdit.ContactPersonName = swimmer.ContactPersonName;
            toEdit.SwimmingExperience = swimmer.SwimmingExperience;
            toEdit.SquadId = swimmer.SquadId;

            this.data.SaveChanges();
        }

        public void Delete(int swimmerId)
        {
            var toDelete = this.data.Swimmers.Find(swimmerId);
            toDelete.IsActive = false;

            this.data.SaveChanges();
        }

        public bool SquadExists(int squadId)
        {
            return this.data.Squads.Any(s => s.Id == squadId);
        }

        public bool SwimmerExists(int swimmerId)
        {
            return this.data.Swimmers.Any(s => s.Id == swimmerId);
        }

        public SwimmerEntryServiceModel SwimmerDetails(int id)
        {
            return this.data.Swimmers
                .Where(s => s.Id == id)
                .Select(s => new SwimmerEntryServiceModel
                {
                    FullName = s.FullName,
                    Age = s.Age,
                    Address = s.Address,
                     Email = s.Email,
                     ContactPersonName = s.ContactPersonName,
                     MedicalDatails = s.MedicalDatails,
                     PhoneNumber = s.PhoneNumber,
                     RelationshipToSwimmer = s.RelationshipToSwimmer,
                     SwimmingExperience = s.SwimmingExperience,
                     SquadId = s.SquadId
                })
                .FirstOrDefault();
        }

        public IEnumerable<SwimmerSquadServiceModel> AllSquads()
        {
            return this.data
                .Squads
                .Select(s => new SwimmerSquadServiceModel
                {
                    Id = s.Id,
                    SquadName = s.SquadName
                });
        }

    }
}
