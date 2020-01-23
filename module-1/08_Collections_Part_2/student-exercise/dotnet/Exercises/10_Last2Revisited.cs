﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Just when you thought it was safe to get back in the water --- Last2Revisited!!!!
         *
         * Given an array of strings, for each string, the count of the number of times that a substring length 2 appears
         * in the string and also as the last 2 chars of the string, so "hixxxhi" yields 1.
         *
         * We don't count the end substring, but the substring may overlap a prior position by one.  For instance, "xxxx"
         * has a count of 2, one pair at position 0, and the second at position 1. The third pair at position 2 is the
         * end substring, which we don't count.
         *
         * Return Dictionary<string, int>, where the key is string from the array, and its last2 count.
         *
         * Last2Revisited(["hixxhi", "xaxxaxaxx", "axxxaaxx"]) → {"hixxhi": 1, "xaxxaxaxx": 1, "axxxaaxx": 2}
         *
         */
        public Dictionary<string, int> Last2Revisited(string[] words)
        {
            Dictionary<string, int> last2Word = new Dictionary<string, int>();
            foreach(string word in words)
            {
                last2Word[word] = Last2(word);
            }
            return last2Word;
        }

        public int Last2(string str)
        {
            int count = 0;
            if (str.Length > 2)
            {
                string lastTwo = str.Substring(str.Length - 2);
                string theRest = str.Substring(0, str.Length - 1);

                for (int i = 0; i < theRest.Length - 1; i++)
                {
                    if (theRest.Substring(i, 2).Equals(lastTwo))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}