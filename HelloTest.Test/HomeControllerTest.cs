using HelloTest.Controllers;
using HelloTest.Models;
using HelloTest.Test.Fake;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace HelloTest.Test
{
    public class HomeControllerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Category("Security Test")]
        public void IndexReturnViewIfConnectedTest()
        {
            //Arrange
            //Fake
            ILogger<HomeController> logger = new MonLogger<HomeController>();
            IMySession sess = new MySession();
            sess.IsLogged = true;
            HomeController ctl = new HomeController(logger, sess);

            //Act
            IActionResult result =   ctl.Index();

            //Assert
            Assert.IsInstanceOf(typeof(ViewResult), result);
        }

        [Test]
        [Category("Security Test")]
        public void IndexReturnToLoginIfNotConnectedTest()
        {
            //Arrange
            ILogger<HomeController> logger = new MonLogger<HomeController>();
            IMySession sess = new MySession();
            sess.IsLogged = false;
            HomeController ctl = new HomeController(logger, sess);

            //Act
            IActionResult result = ctl.Index();

            //Assert
            Assert.IsInstanceOf<RedirectToActionResult>(result);
            Assert.AreEqual("Account", (result as RedirectToActionResult).ControllerName);
            Assert.AreEqual("Login", (result as RedirectToActionResult).ActionName);
        }
    }
}