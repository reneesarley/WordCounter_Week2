using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests.Models.Tests
{
    [TestClass]
    public class WordTest
    {
        [TestMethod]
        public void GetSetWordToScore_SetValueOfWordToScore_String()
        {
            //Arrange
            string testWord = "Car";
            Word newWord = new Word();

            //Act
            newWord.SetWordToScore(testWord);
            string result = newWord.GetWordToScore();

            //Assert
            Assert.AreEqual(result, testWord);
        }
        [TestMethod]
        public void SetGetWordScore_ReturnsWordScore_Int()
        {
            //Arrange
            Word newWord = new Word();

            //Act
            int result = newWord.GetWordScore();
            newWord.SetWordScore(0);

            //Assert
            Assert.AreEqual(0, result);

        }
        [TestMethod]
        public void GetLetterValues_LetterValues_Int()
        {
            //Arrange
            char testLetter = 'l';
            Word newWord = new Word();

            //Act
            int result = newWord.GetLetterValue(testLetter);

            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void BuildLetterValueDictionary_MatchValuesToLetters_Int()
        {
            //Arrange
            char onePointLetter = 'l';
            char twoPointLetter = 'd';
            char threePointLetter = 'b';
            char fourPointLetter = 'v';
            char fivePointLetter = 'k';
            char eightPointLetter = 'j';
            char tenPointLetter = 'q';
            Word newWord = new Word();

            //Act
            int onePointResult = newWord.GetLetterValue(onePointLetter);
            int twoPointResult = newWord.GetLetterValue(twoPointLetter);
            int threePointResult = newWord.GetLetterValue(threePointLetter);
            int fourPointResult = newWord.GetLetterValue(fourPointLetter);
            int fivePointResult = newWord.GetLetterValue(fivePointLetter);
            int eightPointResult = newWord.GetLetterValue(eightPointLetter);
            int tenPointResult = newWord.GetLetterValue(tenPointLetter);

            //Assert
            Assert.AreEqual(onePointResult, 1);
            Assert.AreEqual(twoPointResult, 2);
            Assert.AreEqual(threePointResult, 3);
            Assert.AreEqual(fourPointResult, 4);
            Assert.AreEqual(fivePointResult, 5);
            Assert.AreEqual(eightPointResult, 8);
            Assert.AreEqual(tenPointResult, 10);
        }

        [TestMethod]
        public void CalculateWordScore_CalculateScoreForWord_Int()
        {
            //Arrage
            int testScore = 5;
            Word newWord = new Word();

            //Act
            newWord.SetWordToScore("car");
            newWord.CalculateWordScore();
            int resultScore = newWord.GetWordScore();

            //Assert
            Assert.AreEqual(resultScore, testScore);
        }
    }
}
