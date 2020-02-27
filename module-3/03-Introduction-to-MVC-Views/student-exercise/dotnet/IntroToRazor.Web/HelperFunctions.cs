using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToRazor.Web
{
    public static class HelperFunctions
    {
        public static bool IsFizzBuzz(int number)
        {
            return number % 15 == 0;
        }

        public static bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        public static bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }
    }
}
