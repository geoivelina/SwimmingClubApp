using AutoMapper;
using SwimmingClubApp.Data;
using SwimmingClubApp.Services.Entries;
using SwimmingClubApp.Test.Mocks;
using static SwimmingClubApp.Tests.Data.Squads;
using static SwimmingClubApp.Tests.Data.Swimmers;

namespace SwimmingClubApp.Tests.Services
{
    public class JOinusServiceTests
    {
        protected SwimmingClubDbContext data;
        protected IMapper mapper;
        protected JoinusService swimmerService;

        [SetUp]
        public void Setup()
        {
            this.data = DatabaseMock.Inctance;
            this.mapper = MapperMock.Instance;
            this.swimmerService = new JoinusService(data, mapper);
        }

        [Test]
        public void CreateEntryWithCorrectDataShouldWorkCorrectly()
        {
            var swimmerFullName = "Some";
            var swimmerAge = 55;
            var swimmerContactPersonName = "Name";
            var swimmerRelationshipToSwimmer = "Some";
            var swimmerAddress = "SomeAddress";
            var swimmerEmail = "email@mail.com";
            var swimmerPhoneNumber = "+123456789";
            string swimmerMedicalDatails = "None";
            var swimmerSwimmingExperience = "Some pretty awesome experience in numerous clubs";
            var swimmerSquadId = 1;

            var result = swimmerService.CreateEntry(
                                    swimmerFullName,
                                    swimmerAge,
                                    swimmerEmail,
                                    swimmerPhoneNumber,
                                    swimmerContactPersonName,
                                    swimmerRelationshipToSwimmer,
                                    swimmerAddress,
                                    swimmerMedicalDatails,
                                    swimmerSwimmingExperience,
                                    swimmerSquadId);
            data.SaveChanges();
            var expectedResult = data.Swimmers.Find(1);

            Assert.That(result, Is.EqualTo(1));
            Assert.That(expectedResult.Id, Is.EqualTo(result));
            Assert.That(expectedResult.Address, Is.EqualTo("SomeAddress"));
        }

      
        //TODO: ADD TESTS FOR NEGATIVE OUTPUT
      

        [Test]
        public void EditSwimmerhWithCorrectDataShouldEditSwimmerCorrectly()
        {
            data.Swimmers.AddRange(SwimmersData());
            data.SaveChanges();

            var swimmerId = 1;
            var swimmerFullName = "Levi Miller";
            var swimmerAge = 12;
            var swimmerEmail = "levi@mail.com";
            var swimmerAddress = "SomeTown, SomeStreet, SomeNumber";
            var swimmerPhoneNumber = "+000111222333";
            var swimmerContactPersonName = "Sam Miller";
            var swimmerRelationshipToSwimmer = "Mother";
            var swimmerMedicalDatails = "None";
            var swimmerSwimmingExperience = "Some other swimming club";
            var swimmerSquadId = 1;
           
            swimmerService.EditSwimmer(
                        swimmerId,
                        swimmerFullName,
                        swimmerAge,
                        swimmerEmail,
                        swimmerAddress,
                        swimmerPhoneNumber,
                        swimmerContactPersonName,
                        swimmerMedicalDatails,
                        swimmerRelationshipToSwimmer,
                        swimmerSwimmingExperience,
                        swimmerSquadId);

            var expectedData = data.Swimmers.Find(1);

            Assert.That(expectedData.FullName, Is.EqualTo("Levi Miller"));
        }

        //TODO: ADD TESTS FOR NEGATIVE OUTPUT

        [Test]
        public void DeleteSwimmerShoulddWorkCorrectly()
        {
            data.Swimmers.AddRange(SwimmersData());
            data.SaveChanges();

            swimmerService.DeleteSwimmer(1);
            var result = swimmerService.SwimmerById(1);

            Assert.That(result, Is.EqualTo(0));
        }
        //TODO TESTS FOR NEGATIVE RESULTS

        [Test]
        public void SquadExsistsShouldReturnTrue()
        {
            data.Squads.AddRange(SquadsData());
            data.SaveChanges();

            var result = swimmerService.SquadExists(2);

            Assert.That(result, Is.True);
        }

        [Test]
        public void SquadExsistsShouldReturnFalse()
        {
            data.Squads.AddRange(SquadsData());
            data.SaveChanges();

            var result = swimmerService.SquadExists(5);

            Assert.That(result, Is.False);
        }

        [Test]
        public void AllSquadsShouldWorkCorectly()
        {

            data.Squads.AddRange(SquadsData());
            data.SaveChanges();

            var result = swimmerService.AllSquads();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(3));
        }

        [Test]
        public void AllSquadsWithoutDataShouldReturn0()
        {
            var result = swimmerService.AllSquads();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [TearDown]
        public void TearDown() => this.data.Dispose();
    }
}
