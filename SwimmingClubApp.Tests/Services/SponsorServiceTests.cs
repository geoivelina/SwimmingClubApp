using AutoMapper;
using SwimmingClubApp.Data;
using SwimmingClubApp.Models.About;
using SwimmingClubApp.Services.Sponsors;
using SwimmingClubApp.Services.Sponsors.Models;
using SwimmingClubApp.Test.Mocks;
using static SwimmingClubApp.Tests.Data.Sponsors;

namespace SwimmingClubApp.Tests.Services
{
    public class SponsorServiceTests
    {
        protected SwimmingClubDbContext data;
        protected IMapper mapper;
        protected SponsorService sponsorService;

        [SetUp]
        public void Setup()
        {
            this.data = DatabaseMock.Inctance;
            this.mapper = MapperMock.Instance;
            this.sponsorService = new SponsorService(data, mapper);
        }

        [Test]
        public void CreateSponsorWithCorrectDataShouldCreateSponsor()
        {
            var sponsorName= "Name";
            var sponsordLink = "http://somelonk.com";
            var sponsorLogo= "http://somecoollogo.com";

            var result = sponsorService.CreateSponsor(sponsorName, sponsordLink, sponsorLogo);
            data.SaveChanges();

            var expectesResult = data.Sponsors.Find(1);


            Assert.That(result, Is.EqualTo(1));
            Assert.That(expectesResult.Name, Is.EqualTo("Name"));
        }

        //TODO: TESTS FOR NEGATIVE RESULTS
        [Test]
        public void EditSponsorhWithCorrectDataShouldEditSponsorCorrectly()
        {
            data.Sponsors.AddRange(SponsorsData());
            data.SaveChanges();

            sponsorService.Edit(1, new SponsorFormModel()
            {
                Link = "http://newlink.com",
                Logo = "http://newlogo.com",
                Name = "NewName"
            });

            var sponsorData = data.Sponsors.Find(1);
            var result = sponsorService.AllSponsors().Where(n => n.Id == 1).FirstOrDefault();

            Assert.That(result, Is.Not.Null);
            Assert.That(sponsorData.Name, Is.EqualTo(result.Name));
            Assert.That(sponsorData.Name, Is.EqualTo("NewName"));
        }

        [Test]
        public void EditSponsorhWithWrongIdShouldReturnNullReferenceException()
        {
            data.Sponsors.AddRange(SponsorsData());
            data.SaveChanges();

            Assert.Throws<NullReferenceException>(() =>
                 sponsorService.Edit(5, new SponsorFormModel()
                 {
                     Link = "http://newlink.com",
                     Logo = "http://newlogo.com",
                     Name = "NewName"
                 }));
        }

        [Test]
        public void DeleteSponsorShoulddWorkCorrectly()
        {
            data.Sponsors.AddRange(SponsorsData());
            data.SaveChanges();

            sponsorService.DeleteSponsor(2);
            var result = sponsorService.AllSponsors().Count();

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void DeleteSponsorWithWrongIdShouldReturNullReferenceException()
        {
            data.Sponsors.AddRange(SponsorsData());
            data.SaveChanges();

            Assert.Throws<NullReferenceException>(() =>
                 sponsorService.DeleteSponsor(5));
        }

        [Test]
        public void SponsorDetailsWithExsistingIdShouldReturnCorrectResult()
        {
            data.Sponsors.AddRange(SponsorsData());
            data.SaveChanges();

            var result = sponsorService.Details(1);

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<SponsorDetailsServiceModel>());
            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result.Name, Is.EqualTo("Some"));
        }

        [Test]
        public void SponsorDetailsWithNoneExistentIdShouldInvalidOperationException()
        {
            data.Sponsors.AddRange(SponsorsData());
            data.SaveChanges();
            //WHY INVALIDOPERATIONEX NOT NULLREF??
            Assert.Throws<InvalidOperationException>(()=> sponsorService.Details(5));
        }
        [Test]
        public void SponsorExsistsShouldReturnTrue()
        {
            data.Sponsors.AddRange(SponsorsData());
            data.SaveChanges();

            var result = sponsorService.SponsorExists(2);

            Assert.That(result, Is.True);
        }

        [Test]
        public void SponsorExsistsShouldReturnFalse()
        {
            data.Sponsors.AddRange(SponsorsData());
            data.SaveChanges();

            var result = sponsorService.SponsorExists(7);

            Assert.That(result, Is.False);
        }


        [Test]
        public void AllSponsorsShouldWorkCorretly()
        {
            data.Sponsors.AddRange(SponsorsData());
            data.SaveChanges();

            var result = data.Sponsors;
            int expectedResult = sponsorService.AllSponsors().Count();

            Assert.NotNull(result);
            Assert.That(result.Count(), Is.EqualTo(3));
            Assert.That(expectedResult, Is.EqualTo(result.Count()));
        }

        [Test]
        public void AllSponsorsWhitoutDataShouldRetur0()
        {
            var result = data.Newses;
            int expectedResult = sponsorService.AllSponsors().Count();

            Assert.That(result.Count(), Is.EqualTo(0));
            Assert.That(expectedResult, Is.EqualTo(result.Count()));
        }

        [TearDown]
        public void TearDown() => this.data.Dispose();
    }
}

