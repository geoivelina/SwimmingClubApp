using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Models.About;
using SwimmingClubApp.Services.Data.Models;
using SwimmingClubApp.Services.Sponsors.Models;

namespace SwimmingClubApp.Services.Sponsors
{
    public class SponsorService : ISponsorService
    {
        private readonly SwimmingClubDbContext data;

        public SponsorService(SwimmingClubDbContext data)
        {
            this.data = data;
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

        public void Edit(int id, SponsorFormModel sponsor)
        {
            var toEdit = this.data.Sponsors.Find(id);

            toEdit.Name = sponsor.Name;
            toEdit.Logo = sponsor.Logo;
            toEdit.Link = sponsor.Link;

            this.data.SaveChanges();
        }
        public SponsorDetailsServiceModel Details(int id)
        {
            return this.data.Sponsors
                   .Where(s => s.Id == id && s.IsAvtive)
                   .Select(s => new SponsorDetailsServiceModel
                   {
                       Id = s.Id,
                       HomePageLink = s.Link,
                       Logo = s.Logo,
                       Name = s.Name,
                       IsActive = s.IsAvtive
                   })
                   .First();
        }

        public void DeleteSponsor(int id)
        {
            var toDelete = this.data.Sponsors.Find(id);
            toDelete.IsAvtive = false;

            this.data.SaveChanges();
        }
        public IEnumerable<SponsorDetailsServiceModel> AllSponsors()
        {
            var sponsors = this.data
                        .Sponsors
                        .Where(s => s.IsAvtive)
                        .Select(s => new SponsorDetailsServiceModel
                        {
                            Id = s.Id,
                            Logo = s.Logo,
                            HomePageLink = s.Link,
                            Name = s.Name,
                            IsActive = s.IsAvtive
                        })
                        .ToList();

            return sponsors;
        }
        public bool SponsorExists(int id)
        {
            return this.data.Sponsors.Any(s => s.Id == id);
        }
    }
}
