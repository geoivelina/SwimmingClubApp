using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Controllers;
using SwimmingClubApp.Data;
using SwimmingClubApp.Services.Coaches;
using SwimmingClubApp.Services.Coaches.Models;
using SwimmingClubApp.Services.Sponsors;
using SwimmingClubApp.Test.Mocks;

namespace SwimmingClubApp.Tests.Controllers
{
    public class AboutControllerTests
    {
        protected SwimmingClubDbContext data;
        protected IMapper mapper;
        protected CoachService coachService;
        protected SponsorService sponsorService;
        protected AboutController aboutController;

        [SetUp]
        public void Setup()
        {
            this.data = DatabaseMock.Inctance;
            this.mapper = MapperMock.Instance;
            this.sponsorService = new SponsorService(data, mapper);
            this.coachService = new CoachService(data, mapper);
            this.aboutController = new AboutController(coachService, sponsorService, mapper);
        }

        [Test]
        public void HistoryShouldReturnView()
        {
            var result = aboutController.History();

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<ViewResult>());
        }

        [Test]
        public void FundrisingShouldReturnView()
        {
            var result = aboutController.Fundrising();

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<ViewResult>());
        }

        [Test]
        public void AddCoachGetShouldReturnViewWith()
        {
            var result = aboutController.AddCoach();

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<ViewResult>());
        }

        [Test]
        public void AddCoachWithCorrectDataGetShouldWorkCorrectly()
        {
            var result = aboutController.AddCoach();

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<ViewResult>());
        }
        [Test]
        public void CreateCoachWithCorrectDataShouldCreateNewCoachCorrectly()
        {
            var coachFullName = "Coach Name";
            var coachEmail = "coach@mail.com";
            var coachImage = "http://coachimg.com";
            var coachJobPosition = "coach";
            var coachSquadId = 3;

            var result = coachService.CreateCoach(coachFullName, coachImage, coachEmail, coachSquadId, coachJobPosition);
            data.SaveChanges();

            var expectesResult = data.Coaches.Find(1);

            Assert.That(result, Is.EqualTo(1));
            Assert.That(expectesResult.Id, Is.EqualTo(result));
            Assert.That(expectesResult.SquadId, Is.EqualTo(3));

        }
       
        [Test]
        public void CreateCoachWithWrongSquadIdShouldReturnView()
        {
            var newCoach = new CoachFormModel
            {
                FullName = "Coach Name",
                Email = "coach@mail.com",
                Image = "http://coachimg.com",
                JobPosition = "coach",
                SquadId = 7,
            };

            var result = aboutController.AddCoach(newCoach);

            Assert.That(result, Is.TypeOf<ViewResult>());
        }

        [TearDown]
        public void TearDown() => this.data.Dispose();
    }
}
