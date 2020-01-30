using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        NonStart nonStart;

        [TestInitialize]
        public void Init()
        {
            nonStart = new NonStart();
        }

        [TestMethod]
        public void TestNonStart()
        {
            Assert.AreEqual("BCEF", nonStart.GetPartialString("ABC", "DEF"));
        }
    }
}
