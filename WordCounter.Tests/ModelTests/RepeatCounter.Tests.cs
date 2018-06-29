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
            CounterTest newTest = new CounterTest();
            string testString = "TEST STRING";
            string expected =  "test string";
            string actual = newTest.ConvertToLowerCase(testString);
            Assert.AreEqual(expected, actual);
        }
    }
}
