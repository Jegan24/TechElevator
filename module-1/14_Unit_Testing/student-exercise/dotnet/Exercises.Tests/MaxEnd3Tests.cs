using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    /*  
     Given an array of ints length 3, figure out which is larger between the first and last elements 
     in the array, and set all the other elements to be that value. Return the changed array.
     MakeArray([1, 2, 3]) → [3, 3, 3]
     MakeArray([11, 5, 9]) → [11, 11, 11]
     MakeArray([2, 11, 3]) → [3, 3, 3]
     */
     [TestClass]
    public class MaxEnd3Tests
    {
        MaxEnd3 maxEnd;

        [TestInitialize]
        public void Init()
        {
            maxEnd = new MaxEnd3();
        }

        [TestMethod]
        public void MaxEnd3TestFirstBigger()
        {
            int[] result = maxEnd.MakeArray(new int[] { 3, 2, 1 });
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, result);
        }

        [TestMethod]
        public void MaxEnd3TestLasttBigger()
        {
            int[] result = maxEnd.MakeArray(new int[] { 1, 2, 3 });
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, result);
        }

        [TestMethod]
        public void MaxEnd3TestBothEqual()
        {
            int[] result = maxEnd.MakeArray(new int[] { 3, 2, 3 });
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, result);
        }

        [TestMethod]
        public void MaxEnd3TestBothNegative()
        {
            int[] result = maxEnd.MakeArray(new int[] { -3, 2, -3 });
            CollectionAssert.AreEqual(new int[] { -3, -3, -3 }, result);
        }

        [TestMethod]
        public void MaxEnd3TestMiddleBiggest()
        {
            int[] result = maxEnd.MakeArray(new int[] { 3, int.MaxValue, 1 });
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, result);
        }

    }
}
