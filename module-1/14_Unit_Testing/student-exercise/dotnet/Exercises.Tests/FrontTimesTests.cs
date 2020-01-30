using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTests
    {
        /*
         Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or 
         whatever is there if the string is less than length 3. Return n copies of the front;
         frontTimes("Chocolate", 2) → "ChoCho"	
         frontTimes("Chocolate", 3) → "ChoChoCho"	
         frontTimes("Abc", 3) → "AbcAbcAbc"	
         */
        FrontTimes frontTimes;

        [TestInitialize]
        public void Init()
        {
            frontTimes = new FrontTimes();
        }

        [TestMethod]
        public void FrontTimesTestNormal()
        {
            string result = frontTimes.GenerateString("Chocolate", 2);
            Assert.AreEqual("ChoCho", result);
        }

        [TestMethod]
        public void FrontTimesTestShort()
        {
            string result = frontTimes.GenerateString("Ch", 2);
            Assert.AreEqual("ChCh", result);
        }
    }
}
