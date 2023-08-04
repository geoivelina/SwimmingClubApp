using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Infrastructure.Configurations
{
    public class SwimmersConfiguration : IEntityTypeConfiguration<Swimmer>
    {
        public void Configure(EntityTypeBuilder<Swimmer> builder)
        {
            builder.HasData(CreateSwimmers());
        }

        private List<Swimmer> CreateSwimmers()
        {
            List<Swimmer> swimmers = new List<Swimmer>()
            {
                new Swimmer()
                {
                    Id = 1,
                    FullName = "Levi Miller",
                    SquadId = 1,
                    Email = "levi@mail.com",
                    PhoneNumber = "+000111222333",
                    ContactPersonName = "Sam Miller",
                    RelationshipToSwimmer = "Mother",
                    Address ="SomeTown, SomeStreet, SomeNumber",
                    Age = 12,
                    SwimmingExperience = "Some other swimming club",
                    MedicalDatails = "None"
                },
                new Swimmer()
                {
                    Id = 2,
                    FullName = "Austin Ouyang",
                    SquadId = 3,
                    Email = "austin@mail.com",
                    PhoneNumber = "+000111222333",
                    ContactPersonName = "Some Relative",
                    RelationshipToSwimmer = "Some",
                    Address ="SomeTown, SomeStreet, SomeNumber",
                    Age = 22,
                    SwimmingExperience = "2 other swimming clubs",
                    MedicalDatails = "None"
                },
                new Swimmer()
                {
                    Id = 3,
                    FullName = "Ava Senn",
                    SquadId = 3,
                    Email = "ava@mail.com",
                    PhoneNumber = "+000111222333",
                    ContactPersonName = "Some Relative",
                    RelationshipToSwimmer = "Some",
                    Address ="SomeTown, SomeStreet, SomeNumber",
                    Age = 21,
                    SwimmingExperience = "2 other swimming clubs",
                    MedicalDatails = "None"
                },
                new Swimmer()
                {
                    Id = 4,
                    FullName = "Adam Smith",
                    SquadId = 2,
                    Email = "adam@mail.com",
                    PhoneNumber = "+000111222333",
                    ContactPersonName = "Some Relative",
                    RelationshipToSwimmer = "Some",
                    Address ="SomeTown, SomeStreet, SomeNumber",
                    Age = 18,
                    SwimmingExperience = "2 other swimming clubs",
                    MedicalDatails = "None"
                },
                new Swimmer()
                {
                    Id = 5,
                    FullName = "Maggie Welsh",
                    SquadId = 2,
                    Email = "maggie@mail.com",
                    PhoneNumber = "+000111222333",
                    ContactPersonName = "Some Relative",
                    RelationshipToSwimmer = "Some",
                    Address ="SomeTown, SomeStreet, SomeNumber",
                    Age = 17,
                    SwimmingExperience = "2 other swimming clubs",
                    MedicalDatails = "None"
                }
            };


            return swimmers;
        }
    }
}
