using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class StringExercisesTests
    {
        StringExercises strExer = null;
        
        [TestInitialize]
        public void Setup()
        {
            strExer = new StringExercises();
        }

        //Assert
        //.AreEqual() - compares expected and actual value for equality
        //.AreSame() - verifies two object variables refer to same object
        //.AreNotSame() - verifies two object variables refer to different objects
        //.Fail() - fails without checking conditions
        //.IsFalse()
        //.IsTrue()
        //.IsNotNull()
        //.IsNull()

        [TestMethod]
        public void MakeAbbaTest()
        {
            //arrange
            //StringExercises strExer = new StringExercises();

            //act
            string result = strExer.MakeAbba("Hi", "Bye");

            //assert
            Assert.AreEqual("HiByeByeHi", result);
        }
        [TestMethod]
        public void MakeAbbaTestWithEmptyStrings()
        {
            //arrange
           // StringExercises strExer = new StringExercises();

            //act
            string result = strExer.MakeAbba("", "Bye");

            //assert
            Assert.AreEqual("ByeBye", result,"Here is a message");
        }

        [TestMethod]
        public void MakeAbbaTestWithNullStrings()
        {
            //arrange
            //StringExercises strExer = new StringExercises();

            //act
            string result = strExer.MakeAbba(null, "Bye");

            //assert
            Assert.AreEqual("ByeBye", result, "Here is a message");
        }

        [TestMethod]
        public void MakeFailingTestOnPurpose()
        {

            Assert.IsTrue(false, "Make a failing test on purpose");
        }

        [TestMethod]
        public void DoubleDemo()
        {
            //StringExercises strExer = new StringExercises();
            double result = strExer.ReturnTheDoublePlusPoint5(1.0);
            Assert.AreEqual(1.5, result,.1);
        }

        [TestMethod]
        public void TestMakeOutWord()
        {
            //arrange
            StringExercises strExer = new StringExercises();

            //act
            string result = strExer.MakeOutWord("<<>>", "Bye");

            //assert
            Assert.AreEqual("<<Bye>>", result);
        }

        [TestMethod]
        public void TestFirstTwo()
        {
            string result = strExer.FirstTwo("abcd");
            Assert.AreEqual("ab", result);
            result = strExer.FirstTwo("xxxx");
            Assert.AreEqual("xx", result);
            result = strExer.FirstTwo("1");
            Assert.AreEqual("1", result);
            result = strExer.FirstTwo("");
            Assert.AreEqual("", result);
        }
    }
}