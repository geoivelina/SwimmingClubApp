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
        public void CreateCoachWithCorrectDataShouldCreateNewCoachCorrectly()
        {
            var newCoach = new CoachFormModel
            {
                FullName = "Coach Name",
                Email = "coach@mail.com",
                Image = "http://coachimg.com",
                JobPosition = "coach",
                SquadId = 3
            };

            var result = aboutController.AddCoach(newCoach);
            data.SaveChanges();

            Assert.That(result, Is.Not.Null);
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
