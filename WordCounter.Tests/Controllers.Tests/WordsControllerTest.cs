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
        [TestMethod]
        public void ScoreResult_ReturnsCorrectView_True()
        {
            //Arrange
            WordsController controller = new WordsController();

            //Act
            ActionResult scoreResultView = controller.ScoreResult("testWord");

            //Assert
            Assert.IsInstanceOfType(scoreResultView, typeof(ViewResult));
        }

        [TestMethod]
        public void ScoreResult_HasCorrectModelType_RepeatCounter()
        {
            //Arrange
            WordsController controller = new WordsController();
            ViewResult scoreResultDataType = controller.ScoreResult("testWord") as ViewResult;

            //Act
            var result = scoreResultDataType.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(Word));
        }
    }
}
