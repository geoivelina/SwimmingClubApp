using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Tests.Data
{
    public static class Swimmers
    {
        public static IEnumerable<Swimmer> SwimmersData()
        {
            var swimmers = new List<Swimmer>()
            {
                new Swimmer()
            {
                Id = 1,
                    FullName = "Some Name",
                    SquadId = 1,
                    Email = "mail@mail.com",
                    PhoneNumber = "+000111222333",
                    ContactPersonName = "Name",
                    RelationshipToSwimmer = "Some",
                    Address ="SomeTown, SomeStreet, SomeNumber",
                    Age = 22,
                    SwimmingExperience = "Some other swimming club",
                    MedicalDatails = "None"
            },

            new Swimmer()
            {
                    Id = 2,
                    FullName = "Other Name",
                    SquadId = 1,
                    Email = "other@mail.com",
                    PhoneNumber = "+000111222333",
                    ContactPersonName = "Some other",
                    RelationshipToSwimmer = "Some",
                    Address ="SomeTown, SomeStreet, SomeNumber",
                    Age = 55,
                    SwimmingExperience = "Some other swimming club",
                    MedicalDatails = "None"
            }
            };
            return swimmers;
        }
    }
}
