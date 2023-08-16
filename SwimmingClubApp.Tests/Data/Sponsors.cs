using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Tests.Data
{
    public static class Sponsors
    {
        public static IEnumerable<Sponsor> SponsorsData()
        {
            var sponsors = new List<Sponsor>()
        {
            new Sponsor()
            {
                Id = 1,
                Name = "Some",
                Link = "http://someverycoollink.com",
                Logo = "http://somelogo.com"
            },
            new Sponsor()
            {
                Id = 2,
                Name = "Some2",
                Link = "http://someverycoollink2.com",
                Logo = "http://somelogo2.com"
            },
            new Sponsor()
            {
                Id = 3,
                Name = "Some3",
                Link = "http://someverycoollink3.com",
                Logo = "http://somelogo3.com"
            }
        };
            return sponsors;
        }
    }
}
