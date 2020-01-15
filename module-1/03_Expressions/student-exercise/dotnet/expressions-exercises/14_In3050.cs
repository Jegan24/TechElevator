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
         Given 2 int values, return true if they are both in the range 30..40 inclusive, or they are both
         in the range 40..50 inclusive.
         In3050(30, 31) → true
         In3050(30, 41) → false
         In3050(40, 50) → true
         */
        public bool In3050(int a, int b)
        {
            bool output = false;

            if(In3040(a) && In3040(b))
            {
                output = true;
            }

            if(In4050(a) && In4050(b))
            {
                output = true;
            }

            return output;
        }

        public bool In3040(int number)
        {
            return (number >= 30 && number <= 40);
        }

        public bool In4050(int number)
        {
            return (number >= 40 && number <= 50);
        }

    }
}
