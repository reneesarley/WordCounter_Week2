using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter;
using WordCounter.Models;

namespace WordCounter.Tests.Controllers.Tests
{
    [TestClass]
    public class WordsControllerTest
    {
        [TestMethod]
        public void WordScorer_ReturnsCorrectView_True()
        {
            //Arrange
            WordsController controller = new WordsController();

            //Act
            ActionResult wordScorerView = controller.WordScorer();

            //Assert
            Assert.IsInstanceOfType(wordScorerView, typeof(ViewResult));
        }
    }
}
