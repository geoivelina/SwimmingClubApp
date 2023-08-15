using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Services.Users;
using SwimmingClubApp.Test.Mocks;
using static SwimmingClubApp.Tests.Data.Users;

namespace SwimmingClubApp.Tests.Services
{
    public class UserServiceTests
    {
        private void SeedData(SwimmingClubDbContext context)
        {
            context.AddRange(UsersData());
            context.SaveChanges();
        }
        [Test]
        public void AllUsersShouldReturnAllRegisterdUsers()
        {
            //Arrange
            var data = DatabaseMock.Inctance;
            var mapper = MapperMock.Instance;

            data.Users.AddRange(UsersData());
            data.SaveChanges();

            var userService = new UserService(data, mapper);

            //Act
            var result = userService.AllUsers();

            //ASsert
            //TODO: HOW TO VALIDATE WHAT MODEL IS RETURNING?
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(2));

        }

        [Test]
        public void AllUsersWithoutUsersShouldReturn0()
        {
            //Arrange
            var data = DatabaseMock.Inctance;
            var mapper = MapperMock.Instance;

            var userService = new UserService(data, mapper);

            //Act
            var result = userService.AllUsers();

            //ASsert
            Assert.That(result.Count(), Is.EqualTo(0));

        }

        [Test]
        public void UserFullNameShouldReturnSpecificUserFulllName()
        {
            //Arrange
            var data = DatabaseMock.Inctance;
            var mapper = MapperMock.Instance;

            data.Users.AddRange(UsersData());
            data.SaveChanges();

            var userService = new UserService(data, mapper);
            var userId = "359b285d-706d-4144-bb31-18e48e79addd";
            //Act
            var result = userService.UserFullName(userId);

            //ASsert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo("Test Test2"));
        }

        [Test]
        public void UserFullNameWithWrongIdShouldThrowNullReferenceException()
        {
            //Arrange
            var data = DatabaseMock.Inctance;
            var mapper = MapperMock.Instance;

            data.Users.AddRange(UsersData());
            data.SaveChanges();

            var userService = new UserService(data, mapper);
            var userId = "asdasd";
            //Act
            // var result = userService.UserFullName(userId);

            //ASsert
            Assert.Throws<NullReferenceException>(() => userService.UserFullName(userId));
        }

        [Test]
        public void UserFullNameWithMissingFullNameShouldThrowNullReferenceException()
        {
            //Arrange
            var data = DatabaseMock.Inctance;
            var mapper = MapperMock.Instance;
            var user = new User
            {
                Id = "c9aa458e-5fd0-48a2-b64d-7a31c8f7c65e",
                UserFullName = null,
                Email = "test1@mail.com"
            };

            var userService = new UserService(data, mapper);
            var userId = "c9aa458e-5fd0-48a2-b64d-7a31c8f7c65e";
            //Act
            // var result = userService.UserFullName(userId);

            //ASsert
            Assert.Throws<NullReferenceException>(() => userService.UserFullName(userId));
        }
    }

}
