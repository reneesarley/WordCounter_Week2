using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter;


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
    }
}
