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
    public class LoopsAndArrayExercisesTests
    {
        //CollectionAssert
        //.AllItemsAreNotNull() - Looks at each item in actual collection for not null
        //.AllItemsAreUnique() - Checks for uniqueness among actual collection
        //.AreEqual() - Checks to see if two collections are equal (same order and quantity)
        //.AreEquilavent() - Checks to see if two collections have same element in same quantity, any order
        //.AreNotEqual() - Opposite of AreEqual
        //.AreNotEquilavent() - Opposite or AreEqualivent
        //.Contains() - Checks to see if collection contains a value/object

        [TestMethod]
        public void TestMiddleWay()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6 };
            int[] result = LoopsAndArrayExercises.MiddleWay(a, b);
            //int[] result = LoopsAndArrayExercises.MiddleWay(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 });
            int[] expected = { 2, 5 };

            CollectionAssert.AreEqual(expected, result);

            int[] result2 = LoopsAndArrayExercises.MiddleWay(new int[] { 5, 8, 10 }, new int[] { 24, 24, 24 });

            CollectionAssert.AreEqual(new int[] { 8, 24 }, result2);

        }

        [TestMethod]
        public void TestMaxEnd3()
        {
            //max end 3 is not static so i have to create an object to call it
            LoopsAndArrayExercises lAndAExer = new LoopsAndArrayExercises();

            //test last one is bigger
            int [] result = lAndAExer.MaxEnd3(new int[] { 1, 2, 3 });
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, result);

            //test 1,10,3 or middle is biggest
            result = lAndAExer.MaxEnd3(new int[] { 1, 10, 3 });
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, result);

            //test  first is biggest
            result = lAndAExer.MaxEnd3(new int[] {201, 10, 3 });
            CollectionAssert.AreEqual(new int[] { 201,201,201 }, result);

            //test all same neg
            result = lAndAExer.MaxEnd3(new int[] { -1,-1,-1 });
            CollectionAssert.AreEqual(new int[] { -1,-1,-1}, result);
        }
    }
}