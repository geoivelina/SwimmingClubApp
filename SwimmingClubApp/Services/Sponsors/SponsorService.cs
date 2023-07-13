using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Services.Sponsors.Models;

namespace SwimmingClubApp.Services.Sponsors
{
    public class SponsorService : ISponsorService
    {
        private readonly SimmingClubDbContext data;

        public SponsorService(SimmingClubDbContext data)
        {
            this.data = data;
        }

        public IEnumerable<SponsorServiceModel> AllSponsors()
        {
            var sponsors = this.data
                        .Sponsors
                        .Select(c => new SponsorServiceModel
                        {
                            Logo = c.Logo,
                            HomePageLink = c.Link
                        })
                        .ToList();

            return sponsors;
        }

        public int CreateSponsor(string name, string link, string logo)
        {
            var newSponsor = new Sponsor
            {
                Name = name,
                Link = link,
                Logo = logo
            };

            this.data.Sponsors.Add(newSponsor);
            this.data.SaveChanges();

            return newSponsor.Id;
        }
    }
}
