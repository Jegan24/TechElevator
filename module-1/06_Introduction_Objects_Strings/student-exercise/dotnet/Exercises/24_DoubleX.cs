using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         DoubleX("axxbb") → true
         DoubleX("axaxax") → false
         DoubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            int firstIndex = str.IndexOf("x");
            bool output = false;
            if (firstIndex + 1 < str.Length && firstIndex >= 0)
            {
                output = str.Substring(firstIndex, 2).Equals("xx");
            }
            return output;
        }
    }
}
