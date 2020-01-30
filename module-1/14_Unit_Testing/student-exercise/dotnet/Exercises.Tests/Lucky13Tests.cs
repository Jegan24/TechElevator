using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    /*
     Given an array of ints, return true if the array contains no 1's and no 3's.
     GetLucky([0, 2, 4]) → true
     GetLucky([1, 2, 3]) → false
     GetLucky([1, 2, 4]) → false
     */

    [TestClass]
    public class Lucky13Tests
    {
        Lucky13 lucky;

        [TestInitialize]
        public void Init()
        {
            lucky = new Lucky13();
        }

        [TestMethod]
        public void Lucky13TestShouldPass()
        {
            bool result = lucky.GetLucky(new int[] { 0, 2, 4 });
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Lucky13TestContains1()
        {
            bool result = lucky.GetLucky(new int[] { 0, 1, 4 });
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Lucky13TestContains3()
        {
            bool result = lucky.GetLucky(new int[] { 3, 2, 4 });
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Lucky13TestContainsBoth()
        {
            bool result = lucky.GetLucky(new int[] { 1, 3, 4 });
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Lucky13TestEmpty()
        {
            bool result = lucky.GetLucky(new int[] {});
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Lucky13TestNull()
        {
            bool result = lucky.GetLucky(null);
            Assert.AreEqual(false, result);
        }
    }
}
