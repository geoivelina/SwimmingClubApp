using AutoMapper;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;
using SwimmingClubApp.Models.About;
using SwimmingClubApp.Services.Sponsors.Models;

namespace SwimmingClubApp.Services.Sponsors
{
    public class SponsorService : ISponsorService
    {
        private readonly SwimmingClubDbContext data;
        private readonly IMapper mapper;

        public SponsorService(SwimmingClubDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper;
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

        public void DeleteSponsor(int id)
        {
            var toDelete = this.data.Sponsors.Find(id);
            toDelete.IsAvtive = false;

            this.data.SaveChanges();
        }

        public SponsorDetailsServiceModel Details(int id)
        {
            return this.data.Sponsors
                   .Where(s => s.Id == id && s.IsAvtive)
                   .To<SponsorDetailsServiceModel>()
                   .First();
        }
        public IEnumerable<SponsorDetailsServiceModel> AllSponsors()
        {
            var sponsors = this.data
                        .Sponsors
                        .Where(s => s.IsAvtive)
                        .To<SponsorDetailsServiceModel>()
                        .ToList();

            return sponsors;
        }
        public bool SponsorExists(int id)
        {
            return this.data.Sponsors.Any(s => s.Id == id);
        }
    }
}
