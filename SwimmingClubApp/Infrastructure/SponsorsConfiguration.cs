using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Infrastructure
{
    internal class SponsorsConfiguration : IEntityTypeConfiguration<Sponsor>
    {
        public void Configure(EntityTypeBuilder<Sponsor> builder)
        {
            builder.HasData(CreateSponsors());
        }

        private List<Sponsor> CreateSponsors()
        {
            List<Sponsor> sponsors = new List<Sponsor>()
            {
                new Sponsor()
                {
                    Id= 1,
                    Logo = "https://tse3.mm.bing.net/th?id=OIP.-89jNjevESq6UU7GNDD6ywHaER&pid=Api",
                    Name = "Speedo",
                    Link = "https://www.speedo.com/"
                },
                 new Sponsor()
                {
                    Id = 2,
                    Logo = "https://tse2.mm.bing.net/th?id=OIP.L9mMbV_HUGSUrCUZfDW8RQHaE-&pid=Api",
                    Name = "Arena",
                    Link = "https://www.arenasport.com/en_uk/"
                },
                new Sponsor()
                {
                    Id = 3,
                    Logo = "https://tse2.mm.bing.net/th?id=OIP.YyCM6JJqMvSDO_OtmAmCiwHaEo&pid=Api",
                    Name = "Finis",
                    Link = "https://www.finisswim.com/"
                },
                 new Sponsor()
                {
                    Id = 4,
                    Logo = "https://tse1.mm.bing.net/th?id=OIP.CZ6BOVZa1BgrQKmQ7ojKoQHaDu&pid=Api",
                    Name = "Zoggs",
                    Link = "https://www.zoggs.com/en_GB/"
                }
            };

            return sponsors;
        }
    }
}
