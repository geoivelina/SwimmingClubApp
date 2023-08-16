using AutoMapper;
using SwimmingClubApp.Data;
using SwimmingClubApp.Services.Newses;
using SwimmingClubApp.Services.Newses.Models;
using SwimmingClubApp.Test.Mocks;
using static SwimmingClubApp.Tests.Data.Newses;

namespace SwimmingClubApp.Tests.Services
{
    public class NewsServiceTests
    {
        protected SwimmingClubDbContext data;
        protected IMapper mapper;
        protected NewsService newsService;

        [SetUp]
        public void Setup()
        {
            this.data = DatabaseMock.Inctance;
            this.mapper = MapperMock.Instance;
            this.newsService = new NewsService(data, mapper);
        }
        [Test]
        public void CreateNewshWithCorrectDataShouldCreateNews()
        {
            var newsTitle = "Title";
            var newsCreatedOn = DateTime.UtcNow;
            var newsImage = "http://coachimg.com";
            var newsDescription = "Very long news description in here";

            var result = newsService.CreateNews(newsCreatedOn, newsDescription, newsImage, newsTitle);
            data.SaveChanges();

            var expectesResult = data.Newses.Find(1);

            Assert.That(result, Is.EqualTo(1));
            Assert.That(expectesResult.Title, Is.EqualTo("Title"));
        }

        //TODO: TESTS FOR NEGATIVE RESULTS
        [Test]
        public void EditNewshWithCorrectDataShouldEditCoachCorrectly()
        {
            data.Newses.AddRange(NewsData());
            data.SaveChanges();

            newsService.EditNews(1, new NewsDetailsServiceModel()
            {
                DateCreated = DateTime.UtcNow,
                Desctioption = "Some very awesome description",
                Image = "http://sameoldimg.com",
                Title = "Title"
            });

            var newsData = data.Newses.Find(1);
            var result = newsService.AllNews().Where(n => n.Id == 1).FirstOrDefault();

            Assert.That(result, Is.Not.Null);
            Assert.That(newsData.Title, Is.EqualTo(result.Title));
            Assert.That(newsData.Title, Is.EqualTo("Title"));
        }

        [Test]
        public void EditNewshWithWrongIdShouldReturnNullReferenceException()
        {
            data.Newses.AddRange(NewsData());
            data.SaveChanges();

            Assert.Throws<NullReferenceException>(() =>
                 newsService.EditNews(5, new NewsDetailsServiceModel()
                 {
                     DateCreated = DateTime.UtcNow,
                     Desctioption = "Some very awesome description",
                     Image = "http://sameoldimg.com",
                     Title = "Title"
                 }));
        }

        [Test]
        public void DeleteNewsShoulddWorkCorrectly()
        {
            data.Newses.AddRange(NewsData());
            data.SaveChanges();

            newsService.DeleteNews(2);
            var result = newsService.AllNews().Count();

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void DeleteNewsWithWrongIdShouldReturNullReferenceException()
        {
            data.Newses.AddRange(NewsData());
            data.SaveChanges();

            Assert.Throws<NullReferenceException>(() =>
                 newsService.DeleteNews(5));
        }

        [Test]
        public void NewsDetailsWithExsistingIdShouldReturnCorrectResult()
        {
            data.Newses.AddRange(NewsData());
            data.SaveChanges();

            var result = newsService.Details(1);

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<NewsDetailsServiceModel>());
            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result.Title, Is.EqualTo("Very fancy tatle"));
        }

        [Test]
        public void NewsDetailsWithNoneExistentIdShouldReturnNull()
        {
            data.Newses.AddRange(NewsData());

            var newsService = new NewsService(data, mapper);
            var result = newsService.Details(5);

            Assert.That(result == null, Is.True);
        }
        [Test]
        public void NewsExsistsShouldReturnTrue()
        {
            data.Newses.AddRange(NewsData());
            data.SaveChanges();

            var result = newsService.NewsExists(2);

            Assert.That(result, Is.True);
        }

        [Test]
        public void NewsExsistsShouldReturnFalse()
        {
            data.Newses.AddRange(NewsData());
            data.SaveChanges();

            var result = newsService.NewsExists(5);

            Assert.That(result, Is.False);
        }

        
        [Test]
        public void AllNewsShouldWorkCorretly()
        {
            data.Newses.AddRange(NewsData());
            data.SaveChanges();

            var result = data.Newses;
            int expectedResult = newsService.AllNews().Count();

            Assert.NotNull(result);
            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(expectedResult, Is.EqualTo(result.Count()));

        }

        [Test]
        public void AllNewsWhitoutDataShouldRetur0()
        {
            var result = data.Newses;
            int expectedResult = newsService.AllNews().Count();

            Assert.That(result.Count(), Is.EqualTo(0));
            Assert.That(expectedResult, Is.EqualTo(result.Count()));
        }

        [TearDown]
        public void TearDown() => this.data.Dispose();
    }
}
