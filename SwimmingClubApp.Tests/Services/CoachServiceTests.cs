using SwimmingClubApp.Data;
using SwimmingClubApp.Services.Coaches;
using SwimmingClubApp.Services.Coaches.Models;
using SwimmingClubApp.Test.Mocks;
using static SwimmingClubApp.Tests.Data.Coaches;

namespace SwimmingClubApp.Tests.Services
{
    public class CoachServiceTests
    {
        private ICoachService coaches;
        private void SeedData(SwimmingClubDbContext context)
        {
            context.AddRange(CoachesData());
            context.SaveChanges();
        }


        [Test]
        public void AllCoachesWithDataShouldReturnCorrectlyAllCoached()
        {
            var data = DatabaseMock.Inctance;
            var mapper = MapperMock.Instance;
            data.Coaches.AddRange(CoachesData());

            data.SaveChanges();

            var coachService = new CoachService(data, mapper);

            var result = coachService.AllCoaches();

            Assert.NotNull(result);
            Assert.That(result.Count(), Is.EqualTo(3));
        }

        [Test]
        public void AllCoachesWithoutDataShouldReturn0()
        {
            var data = DatabaseMock.Inctance;
            var mapper = MapperMock.Instance;

            var coachService = new CoachService(data, mapper);

            //TODO: IS IT IN THE MAPPING?
            var result = coachService.AllCoaches();

            Assert.True(result.Count() == 0);
        }

        [Test]
        public void CoachDetailsWithExsistingIdShouldReturnCorrectResult()
        {
            var data = DatabaseMock.Inctance;
            var mapper = MapperMock.Instance;
            data.Coaches.AddRange(CoachesData());

            data.SaveChanges();

            var coachService = new CoachService(data, mapper);

            var result = coachService.CoachDetails(1);

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<CoachDetailsServiceModel>());
            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result.FullName, Is.EqualTo("Some Name"));
        }

        [Test]
        public void CoachDetailsWithNoneExistentIdShouldReturnNull()
        {
            var data = DatabaseMock.Inctance;
            var mapper = MapperMock.Instance;
            data.Coaches.AddRange(CoachesData());

            data.SaveChanges();

            var coachService = new CoachService(data, mapper);

            var result = coachService.CoachDetails(5);

            Assert.That(result == null, Is.True);

        }

        [Test]
        public void CreateCoachWithCorrectDataShouldCreateNewCoachCorrectly()
        {
            var data = DatabaseMock.Inctance;
            var mapper = MapperMock.Instance;
            var coachService = new CoachService(data, mapper);


            var coachFullName = "Coach Name";
            var coachEmail = "coach@mail.com";
            var coachImage = "http://coachimg.com";
            var coachJobPosition = "coach";
            var coachSquadId = 3;

            var result = coachService.CreateCoach(coachFullName, coachImage, coachEmail, coachSquadId, coachJobPosition);
            data.SaveChanges();


            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void CreateCoachWithCorrectDataShouldCreateNewCoachCorrectly2()
        {
            var data = DatabaseMock.Inctance;
            var mapper = MapperMock.Instance;
            var coachService = new CoachService(data, mapper);


            var coachFullName = "Coach Name";
            var coachEmail = "coach@mail.com";
            var coachImage = "http://coachimg.com";
            var coachJobPosition = "coach";
            var coachSquadId = 3;

            var result = coachService.CreateCoach(coachFullName, coachImage, coachEmail, coachSquadId, coachJobPosition);
            data.SaveChanges();
            var expectedResult = data.Coaches.Where(c => c.Id == 1).FirstOrDefault();

            Assert.True(expectedResult.Id == 1);
            Assert.True(expectedResult.FullName == "Coach Name");
            Assert.True(expectedResult.Image == "http://coachimg.com");
        }


        [Test]
        public void EditCoachWithCorrectDataShouldEditCoachCorrectly()
        {
            var data = DatabaseMock.Inctance;
            var mapper = MapperMock.Instance;
            var coachService = new CoachService(data, mapper);
            data.Coaches.AddRange(CoachesData());

            data.SaveChanges();

            coachService.Edit(3, new CoachFormModel()
            {
                Email = "",
                FullName = "",
                Image = "",
                SquadId = 3,
                JobPosition = "new poss",
            });
            var coachData = coachService.CoachDetails(3);


            Assert.That(coachData.JobPosition, Is.EqualTo("new poss"));
        }


    }
}
