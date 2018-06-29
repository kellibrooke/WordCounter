using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void ConvertToLowerCase_MakesAllLettersLowerCase_String()
        {
            RepeatCounter newTest = new RepeatCounter();
            string testString = "TEST STRING";
            string expected =  "test string";
            string actual = newTest.ConvertToLowerCase(testString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SentenceToWords_SplitsSentenceIntoWords_StringArray()
        {
          RepeatCounter newTest = new RepeatCounter();
          string testString = "test string";
          string[] expected =  { "test", "string" };
          string[] actual = newTest.SentenceToWords(testString);
          CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContainsNoPunctuation_ChecksWordCharsAreLetters_True()
        {
          RepeatCounter newTest = new RepeatCounter();
          string testString = "test";
          bool expected =  true;
          bool actual = newTest.ContainsNoPunctuation(testString);
          Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContainsNoPunctuation_ChecksWordCharsAreLetters_False()
        {
          RepeatCounter newTest = new RepeatCounter();
          string testString = "tes44t";
          bool expected =  false;
          bool actual = newTest.ContainsNoPunctuation(testString);
          Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateWordTally_ChecksWordsAddedValuesCorrect_DictDef()
        {
          RepeatCounter newTest = new RepeatCounter();
          string[] testWords = { "test", "words"};
          int expected = 1;
          newTest.CreateWordTally(testWords);
          Dictionary<string, int> actualTally = newTest.GetTally();
          actualTally.TryGetValue("test", out int actual);
          Assert.AreEqual(expected, actual);
        }
    }
}
