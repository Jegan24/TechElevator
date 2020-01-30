using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTests
    {
        StringBits stringBits;

        [TestInitialize]
        public void Init()
        {
            stringBits = new StringBits();
        }

        [TestMethod]
        public void StringBitsTestEven()
        {
            Assert.AreEqual("ACE", stringBits.GetBits("ABCDEF"));
        }

        [TestMethod]
        public void StringBitsTestOdd()
        {
            Assert.AreEqual("ACE", stringBits.GetBits("ABCDE"));
        }

        [TestMethod]
        public void StringBitsTestOne()
        {
            Assert.AreEqual("A", stringBits.GetBits("A"));
        }

        [TestMethod]
        public void StringBitsTestEmpty()
        {
            Assert.AreEqual("", stringBits.GetBits(""));
        }

        [TestMethod]
        public void StringBitsTestNull()
        {
            Assert.AreEqual(null, stringBits.GetBits(null));
        }
    }
}
