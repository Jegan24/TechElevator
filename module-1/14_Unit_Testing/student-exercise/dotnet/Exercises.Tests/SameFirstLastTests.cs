using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        SameFirstLast firstLast;

        [TestInitialize]
        public void Init()
        {
            firstLast = new SameFirstLast();
        }

        [TestMethod]
        public void FirstLastTestZeroLength()
        {
            Assert.AreEqual(false, firstLast.IsItTheSame(new int[] { }));
        }

        [TestMethod]
        public void FirstLastTestOneLength()
        {
            Assert.AreEqual(true, firstLast.IsItTheSame(new int[] { 1 }));
        }

        [TestMethod]
        public void FirstLastTestSame()
        {
            Assert.AreEqual(true, firstLast.IsItTheSame(new int[] { 1, 2, 3, 2, 1 }));
        }

        [TestMethod]
        public void FirstLastTestDifferent()
        {
            Assert.AreEqual(false, firstLast.IsItTheSame(new int[] { 1, 2, 3 }));
        }

    }
}
