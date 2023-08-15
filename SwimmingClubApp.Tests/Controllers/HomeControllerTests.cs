using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Controllers;

namespace SwimmingClubApp.Test.Controllers
{
    public class HomeControllerTests
    {

        [Test]
        public void ErrorShouldReturnView()
        {
            //Arrange
            var homeController = new HomeController();
            //Act
            var result = homeController.Error();
            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<ViewResult>());
        }

        [Test]
        public void MoreShouldReturnView()
        {
            //Arrange
            var homeController = new HomeController();
            //Act
            var result = homeController.More();
            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<ViewResult>());
        }

        [Test]
        public void ScheduleShouldReturnView()
        {
            //Arrange
            var homeController = new HomeController();
            //Act
            var result = homeController.More();
            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<ViewResult>());
          
        }

    }
}
