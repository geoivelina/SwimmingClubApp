using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Tests.Data
{
    public static class Coaches
    {
        public static IEnumerable<Coach> CoachesData()
        {
            var coaches = new List<Coach>()
        {
            new Coach()
            {
                Id = 1,
                FullName = "Some Name",
                Email = "some@email.com",
                Image = "http://someling.com",
                IsAvtive = true,
                JobPosition = "Spme Job Poss",
                Squad = new Squad
                {
                    Id = 1,
                    SquadName = "SomeSquad"
                }
            },
            new Coach()
            {
                Id = 2,
                FullName = "Some Name",
                Email = "some@email.com",
                Image = "http://someling.com",
                IsAvtive = true,
                JobPosition = "Spme Job Poss",
                 Squad = new Squad
                {
                    Id = 2,
                    SquadName = "SomeSquad2"
                }
            },
            new Coach()
            {
                Id = 3,
                FullName = "Some Name",
                Email = "some@email.com",
                Image = "http://someling.com",
                IsAvtive = true,
                JobPosition = "Spme Job Poss",
                 Squad = new Squad
                {
                    Id = 3,
                    SquadName = "SomeSquad3"
                }
            }
        };
            return coaches;
        }
    }
}
