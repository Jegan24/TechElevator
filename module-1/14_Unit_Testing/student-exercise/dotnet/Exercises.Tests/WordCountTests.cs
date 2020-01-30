using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    /*
    * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the 
    * number of times that string appears in the array.
    * 
    * ** A CLASSIC **
    * 
    * GetCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
    * GetCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
    * GetCount([]) → {}
    * GetCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
    * 
    */
    [TestClass]
    public class WordCountTests
    {
        WordCount wordCount;

        [TestInitialize]
        public void Init()
        {
            wordCount = new WordCount();
        }

        [TestMethod]
        public void WordCountTestBasic()
        {
            Dictionary<string, int> result = wordCount.GetCount(new string[] { "ba", "ba", "black", "sheep" });
            Dictionary<string, int> expected = new Dictionary<string, int>();
            expected["ba"] = 2;
            expected["black"] = 1;
            expected["sheep"] = 1;
            CollectionAssert.AreEqual(expected, result);

        }

        [TestMethod]
        public void WordCountTestLetters()
        {
            Dictionary<string, int> result = wordCount.GetCount(new string[] { "a", "b", "a", "c", "b" });
            Dictionary<string, int> expected = new Dictionary<string, int>();
            expected["a"] = 2;
            expected["b"] = 2;
            expected["c"] = 1;
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WordCountTestEmpty()
        {
            Dictionary<string, int> result = wordCount.GetCount(new string[] { });
            Dictionary<string, int> expected = new Dictionary<string, int>();
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WordCountTestOneOfEach()
        {
            Dictionary<string, int> result = wordCount.GetCount(new string[] { "c", "b", "a" });
            Dictionary<string, int> expected = new Dictionary<string, int>();
            expected["c"] = 1;
            expected["b"] = 1;
            expected["a"] = 1;
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WordCountTestNull()
        {
            CollectionAssert.AreEqual(null, wordCount.GetCount(null));
        }
    }
}
