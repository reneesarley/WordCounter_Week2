using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter;
using WordCounter.Models;

namespace WordCounter.Tests.Controllers.Tests
{
    [TestClass]
    public class RepeatCountersControllerTest
    {
        [TestMethod]
        public void Start_ReturnsCorrectView_True()
        {
            //Arrange
            RepeatCountersController controller = new RepeatCountersController();

            //Act
            ActionResult startView = controller.Start();

            //Assert
            Assert.IsInstanceOfType(startView, typeof(ViewResult));
        }

        [TestMethod]
        public void Count_ReturnsCorrectView_True()
        {
            //Arrange
            RepeatCountersController controller = new RepeatCountersController();

            //Act
            ActionResult countView = controller.Count("testWord", "testString");

            //Assert
            Assert.IsInstanceOfType(countView, typeof(ViewResult));
        }

        [TestMethod]
        public void Count_HasCorrectModelType_RepeatCounter()
        {
            //Arrange
            RepeatCountersController controller = new RepeatCountersController();
            ViewResult countDataType = controller.Count("testWord", "testString")as ViewResult;

            //Act
            var result = countDataType.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(RepeatCounter));
        }
    }
 }
