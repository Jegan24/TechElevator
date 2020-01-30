using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {
        AnimalGroupName agn;

        [TestMethod]
        public void TestCase()
        {
            agn = new AnimalGroupName();
            string result = agn.GetHerd("RHiNO");

            Assert.AreEqual("Crash", result);
        }

        [TestMethod]
        public void TestNotIncluded()
        {
            agn = new AnimalGroupName();
            string result = agn.GetHerd("Dragon");
            Assert.AreEqual("unknown", result);
        }

        [TestMethod]
        public void NullString()
        {
            agn = new AnimalGroupName();
            string result = agn.GetHerd(null);
            Assert.AreEqual("unknown", result);
        }
    }
}
