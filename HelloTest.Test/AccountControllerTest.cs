
using HelloTest.Controllers;
using HelloTest.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTest.Test
{
    public class AccountControllerTest
    {
        [Test]
        public void IndexRedirectPermanentToLoginTest()
        {
            //Arrange
            IMySession sess = new MySession();
            sess.IsLogged = true;
            AccountController ctl = new AccountController(sess);

            //Act
            IActionResult result = ctl.Index();

            //Assert
            Assert.IsInstanceOf<RedirectToActionResult>(result);
        }

    }
}
