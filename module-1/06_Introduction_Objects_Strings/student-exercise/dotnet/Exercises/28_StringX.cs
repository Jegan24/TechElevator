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
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            string output;
            if (str.Length > 1)
            {
                string first = str.Substring(0, 1);
                string middle = str.Substring(1, str.Length - 2).Replace("x", "");
                string last = str.Substring(str.Length - 1);
                output = first + middle + last;
            }
            else
            {
                output = str;
            }

            return output;
        }
    }
}
