using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Controllers;
using SwimmingClubApp.Services.Coaches;
using SwimmingClubApp.Services.Coaches.Models;
using SwimmingClubApp.Services.Sponsors;
using SwimmingClubApp.Test.Mocks;

namespace SwimmingClubApp.Tests.Controllers
{
    public class AboutControllerTests
    {

        [Test]
        public void CreateCoachWithCorrectDataShouldCreateNewCoachCorrectly()
        {
            var data = DatabaseMock.Inctance;
            var mapper = MapperMock.Instance;
            var coachService = new CoachService(data, mapper);
            var sponsorService = new SponsorService(data, mapper);
            var aboutController = new AboutController(coachService, sponsorService, mapper);

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
            var data = DatabaseMock.Inctance;
            var mapper = MapperMock.Instance;
            var coachService = new CoachService(data, mapper);
            var sponsorService = new SponsorService(data, mapper);
            var aboutController = new AboutController(coachService, sponsorService, mapper);

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
    }
}
