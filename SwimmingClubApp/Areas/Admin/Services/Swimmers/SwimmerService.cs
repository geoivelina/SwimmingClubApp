using SwimmingClubApp.Data;
using SwimmingClubApp.Services.Entries.Models;

namespace SwimmingClubApp.Areas.Admin.Services.Swimmers
{
    public class SwimmerService : ISwimmerService
    {
        private readonly SimmingClubDbContext data;

        public SwimmerService(SimmingClubDbContext data)
        {
            this.data = data;
        }


        public void Edit(
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
    }
}
