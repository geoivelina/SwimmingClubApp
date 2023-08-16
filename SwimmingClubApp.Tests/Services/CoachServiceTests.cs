using AutoMapper;
using SwimmingClubApp.Data;
using SwimmingClubApp.Services.Coaches;
using SwimmingClubApp.Services.Coaches.Models;
using SwimmingClubApp.Test.Mocks;
using static SwimmingClubApp.Tests.Data.Coaches;
using static SwimmingClubApp.Tests.Data.Squads;

namespace SwimmingClubApp.Tests.Services
{
    public class CoachServiceTests
    {
        protected SwimmingClubDbContext data;
        protected IMapper mapper;
        protected CoachService coachService;

        [SetUp]
        public void Setup()
        {
            this.data = DatabaseMock.Inctance;
            this.mapper = MapperMock.Instance;
            this.coachService = new CoachService(data, mapper);
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
        public void CreateCoachWithCorrectDataShouldCreateNewCoachCorrectly2()
        {
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

        //TODO: TESTS FOR NEGATIVE RESULTS
        [Test]
        public void CoachDetailsWithExsistingIdShouldReturnCorrectResult()
        {
           
            data.Coaches.AddRange(CoachesData());
            data.SaveChanges();

            var result = coachService.CoachDetails(1);

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<CoachDetailsServiceModel>());
            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result.FullName, Is.EqualTo("Some Name"));
        }

        [Test]
        public void CoachDetailsWithNoneExistentIdShouldReturnNull()
        {
            data.Coaches.AddRange(CoachesData());
            data.SaveChanges();

            var result = coachService.CoachDetails(5);

            Assert.That(result == null, Is.True);
        }
        [Test]
        public void EditCoachWithCorrectDataShouldEditCoachCorrectly()
        {
            data.Coaches.AddRange(CoachesData());
            data.SaveChanges();

            coachService.EditCoach(3, new CoachFormModel()
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

        [Test]
        public void EditCoachWithWrongIdShouldReturnNullReferenceException()
        {
            data.Coaches.AddRange(CoachesData());
            data.SaveChanges();

            Assert.Throws<NullReferenceException>(() =>
                 coachService.EditCoach(5, new CoachFormModel()
                 {
                     Email = "",
                     FullName = "",
                     Image = "",
                     SquadId = 4,
                     JobPosition = "new poss",
                 }));
        }

        [Test]
        public void DeleteCoachShoulddWorkCorrectly()
        {
            data.Coaches.AddRange(CoachesData());
            data.SaveChanges();

            coachService.DeleteCoach(2);
            var result = coachService.AllCoaches().Count();

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void DeleteCoachWithWrongIdShouldReturNullReferenceException()
        {
            data.Coaches.AddRange(CoachesData());
            data.SaveChanges();

            Assert.Throws<NullReferenceException>(() =>
                 coachService.DeleteCoach(5));
        }

        [Test]
        public void AllCoachesWithDataShouldReturnCorrectlyAllCoached()
        {
            data.Coaches.AddRange(CoachesData());
            data.SaveChanges();

            var result = coachService.AllCoaches();

            Assert.NotNull(result);
            Assert.That(result.Count(), Is.EqualTo(3));
        }

        [Test]
        public void AllCoachesWithoutDataShouldReturn0()
        {
            //TODO: IS IT IN THE MAPPING?
            var result = coachService.AllCoaches();

            Assert.True(result.Count() == 0);
        }

        [Test]
        public void AllSquadsShouldWorkCorectly()
        {
            data.Squads.AddRange(SquadsData());
            data.SaveChanges();

            var result = coachService.AllSquads();
           
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(3));
        }

        [Test]
        public void AllSquadsWithoutDataShouldReturn0()
        {
            var result = coachService.AllSquads();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public void SquadExsistsShouldReturnTrue()
        {
            data.Squads.AddRange(SquadsData());
            data.SaveChanges();

            var result = coachService.SquadExists(2);

            Assert.That(result, Is.True);
        }

        [Test]
        public void SquadExsistsShouldReturnFalse()
        {
            data.Squads.AddRange(SquadsData());
            data.SaveChanges();

            var result = coachService.SquadExists(5);

            Assert.That(result, Is.False);
        }

        [Test]
        public void CoachExsistsShouldReturnTrue()
        {
            data.Coaches.AddRange(CoachesData());
            data.SaveChanges();

            var result = coachService.CoachExists(2);

            Assert.That(result, Is.True);
        }

        [Test]
        public void CoachExsistsShouldReturnFalse()
        {
            data.Coaches.AddRange(CoachesData());
            data.SaveChanges();

            var result = coachService.CoachExists(7);

            Assert.That(result, Is.False);
        }

        [TearDown]
        public void TearDown() => this.data.Dispose();
    }
}
