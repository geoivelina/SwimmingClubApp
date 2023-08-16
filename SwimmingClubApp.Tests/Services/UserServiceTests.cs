using AutoMapper;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Services.Users;
using SwimmingClubApp.Test.Mocks;
using static SwimmingClubApp.Tests.Data.Users;

namespace SwimmingClubApp.Tests.Services
{
    public class UserServiceTests
    {
        protected SwimmingClubDbContext data;
        protected IMapper mapper;
        protected UserService userService;

        [SetUp]
        public void Setup()
        {
            this.data = DatabaseMock.Inctance;
            this.mapper = MapperMock.Instance;
            this.userService = new UserService(data, mapper);
        }
        
        [Test]
        public void AllUsersShouldReturnAllRegisterdUsers()
        {
            data.Users.AddRange(UsersData());
            data.SaveChanges();

            var result = userService.AllUsers();

            //TODO: HOW TO VALIDATE WHAT MODEL IS RETURNING?
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(2));

        }

        [Test]
        public void AllUsersWithoutEntriesInDbShouldReturn0()
        {
            var result = userService.AllUsers();

            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public void UserFullNameShouldReturnSpecificUserFulllName()
        {
            data.Users.AddRange(UsersData());
            data.SaveChanges();

            var userId = "359b285d-706d-4144-bb31-18e48e79addd";
            //Act
            var result = userService.UserFullName(userId);

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo("Test Test2"));
        }

        [Test]
        public void UserFullNameWithWrongIdShouldThrowNullReferenceException()
        {

            data.Users.AddRange(UsersData());
            data.SaveChanges();
            var userId = "asdasd";
            
            Assert.Throws<NullReferenceException>(() => userService.UserFullName(userId));
        }

        [Test]
        public void UserFullNameWithMissingFullNameShouldThrowNullReferenceException()
        {
            var user = new User
            {
                Id = "c9aa458e-5fd0-48a2-b64d-7a31c8f7c65e",
                UserFullName = null,
                Email = "test1@mail.com"
            };
            var userId = "c9aa458e-5fd0-48a2-b64d-7a31c8f7c65e";
           
            Assert.Throws<NullReferenceException>(() => userService.UserFullName(userId));
        }

        [TearDown]
        public void TearDown() => this.data.Dispose();
    }

}
