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
      Given 2 positive int values, return the larger value that is in the range 10..20 inclusive,
      or return 0 if neither is in that range.
      Max1020(11, 19) → 19
      Max1020(19, 11) → 19
      Max1020(11, 9) → 11
      */
        public int Max1020(int a, int b)
        {
            int output = 0;
            bool isInRangeA = false;
            bool isInRangeB = false;

            if(!LessThan10(a) && !GreaterThan20(a))
            {
                isInRangeA = true;
            }

            if (!LessThan10(b) && !GreaterThan20(b))
            {
                isInRangeB = true;
            }

            if(isInRangeA && isInRangeB)
            {
                if(a > b && isInRangeA)
                {
                    output = a;
                }
                else
                {
                    output = b;
                }
            }
            else if (isInRangeA)
            {
                output = a;
            }
            else if (isInRangeB)
            {
                output = b;
            }

            return output; 
        }

        public bool LessThan10(int number)
        {
            return (number < 10);
        }

        public bool GreaterThan20(int number)
        {
            return (number > 20);
        }

    }
}
