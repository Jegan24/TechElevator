using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Return true if the given non-negative number is 1 or 2 more than a multiple of 20.
         (Hint: Think "mod".)
         More20(20) → false
         More20(21) → true
         More20(22) → true
         */
        public bool More20(int n)
        {
            bool output = false;
            if(IsMultipleOf(n-1, 20) || IsMultipleOf(n - 2, 20))
            {
                output = true;
            }
            return output;
        }

        //public bool IsMultipleOf20(int number)
        //{
        //    return number % 20 == 0;
        //}

        public bool IsMultipleOf(int number, int factor)
        {
            return number % factor == 0;
        }

    }
}
