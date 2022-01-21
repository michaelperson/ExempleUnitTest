using HelloTest.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTest.Test
{
    public class MathControllerTest
    {
        [Test]
        public void IndexReturnTest()
        {
            //Arrange
            MathController ctl = new MathController();

            //Act

            IActionResult result = ctl.Index();

            //Assert
            Assert.IsInstanceOf<ViewResult>(result);
        }
        [Test]
        public void IndexReturnWithSumResultTest()
        {
            //Arrange
            MathController ctl = new MathController();

            //Act

            IActionResult result = ctl.Index(45,20);

            //Assert
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.AreEqual("Le résultat de l'addition = 65", (result as ViewResult).ViewData["resultat"].ToString());
        }


    }
}
