using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Tests
    {
        /*
         Return true if the given non-negative number is 1 or 2 less than a multiple of 20. So for example 38 
         and 39 return true, but 40 returns false. 
         (Hint: Think "mod".)
         less20(18) → true
         less20(19) → true
         less20(20) → false
         */
        Less20 less;

        [TestInitialize]
        public void Init()
        {
            less = new Less20();
        }

        [TestMethod]
        public void Less20IsTwoLess()
        {
            bool result = less.IsLessThanMultipleOf20(18);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Less20IsOneLess()
        {
            bool result = less.IsLessThanMultipleOf20(19);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Less20IsEqual()
        {
            bool result = less.IsLessThanMultipleOf20(20);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Less20IsWayOff()
        {
            bool result = less.IsLessThanMultipleOf20(30);
            Assert.AreEqual(false, result);
        }
    }
}
