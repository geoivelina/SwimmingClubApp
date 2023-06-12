using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Infrastructure
{
    internal class CoachesConfiguration : IEntityTypeConfiguration<Coach>
    {
        public void Configure(EntityTypeBuilder<Coach> builder)
        {
            builder.HasData(CreateCoaches());
        }

        private List<Coach> CreateCoaches()
        {
            List<Coach> coaches = new List<Coach>() {
            new Coach()
            {
                Id = 1,
                FullName = "Emma Harris",
                Email = "e.harris@mail.com",
                JobPosition = "Coach",
                SquadId = 1,
                Image = "https://tse4.mm.bing.net/th?id=OIP.6Ue-IdphavC3AxW8adedCAHaHa&pid=Api"
            },
            new Coach()
            {
                Id = 2,
                FullName = "Sam Smith",
                Email = "sam.smith@mail.com",
                JobPosition = "Junior Head Coach",
                SquadId = 2,
                Image = "https://tse2.mm.bing.net/th?id=OIP.5cla8U39A4eNC8xzRCMDiQHaHa&pid=Api"
            },
             new Coach()
            {
                Id = 3,
                FullName = "Justin Robin",
                Email = "justin.robin@mail.com",
                JobPosition = "Senior Swimming Instructor",
                SquadId = 2,
                Image = "https://tse2.mm.bing.net/th?id=OIP.5cla8U39A4eNC8xzRCMDiQHaHa&pid=Api"
            },
             new Coach()
            {
                 Id = 4,
                FullName = "Cindy Somerton",
                Email = "cindy.somerton@mail.com",
                JobPosition = "General Manager",
                SquadId = 2,
                Image = "https://tse4.mm.bing.net/th?id=OIP.6Ue-IdphavC3AxW8adedCAHaHa&pid=Api"
            },
            };
            return coaches;
        }
    }
}
