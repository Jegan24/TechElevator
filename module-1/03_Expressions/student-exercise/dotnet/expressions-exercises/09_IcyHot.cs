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
         Given two temperatures, return true if one is less than 0 and the other is greater than 100.
         IcyHot(120, -1) → true
         IcyHot(-1, 120) → true
         IcyHot(2, 120) → false
         */
        public bool IcyHot(int temp1, int temp2)
        {
            int high;
            int low;
            bool output = temp1 != temp2;
            if (output)
            {
                if (temp1 > temp2)
                {
                    high = temp1;
                    low = temp2;
                }
                else
                {
                    high = temp2;
                    low = temp1;
                }

                if(!(high > 100 && low < 0))
                {
                    output = false;
                }
            }

            
            return output;
        }

    }
}
