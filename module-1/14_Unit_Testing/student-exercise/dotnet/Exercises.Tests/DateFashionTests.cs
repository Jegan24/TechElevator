using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTests
    {
        /*
        You and your date are trying to get a table at a restaurant. The parameter "you" is the stylishness
        of your clothes, in the range 0..10, and "date" is the stylishness of your date's clothes. The result
        getting the table is encoded as an int value with 0=no, 1=maybe, 2=yes. If either of you is very 
        stylish, 8 or more, then the result is 2 (yes). With the exception that if either of you has style of 
        2 or less, then the result is 0 (no). Otherwise the result is 1 (maybe).
        dateFashion(5, 10) → 2
        dateFashion(5, 2) → 0
        dateFashion(5, 5) → 1
        */
        DateFashion dateFashion;

        [TestInitialize]
        public void Init()
        {
            dateFashion = new DateFashion();
        }

        [TestMethod]
        public void DateFashionTestVeryStylish()
        {
            int result = dateFashion.GetATable(10, 3);
            Assert.AreEqual(2, result);

            result = dateFashion.GetATable(3, 10);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DateFashionNoStyle()
        {
            int result = dateFashion.GetATable(10, 1);
            Assert.AreEqual(0, result);

            result = dateFashion.GetATable(2, 10);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void DateFashionMediocreStyle()
        {
            int result = dateFashion.GetATable(3, 7);
            Assert.AreEqual(1, result);

            result = dateFashion.GetATable(5, 5);
            Assert.AreEqual(1, result);
        }
    }
}
