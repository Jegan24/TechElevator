using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureExample
    {
        /*
        16. Return "Big Even Number" when number is even, larger than 100, and a multiple of 5.
            Return "Big Number" if the number is just larger than 100.
            Return empty string for everything else.
            TOPIC: Complex Expression
        */
        public string ReturnBigEvenNumber(int number)
        {
            string returnString = "";
            /*
            if (number>100 && number%2==0 && number % 5 == 0)
            {
                returnString = "Big Even Number";
            }
            else if (number>100)
            {
                returnString = "Big Number";
            }
            */
            /*
            if (number > 100)
            {
                if (number % 2 == 0 && number % 5 == 0)
                    returnString = "Big Even Number";
                else
                    returnString = "Big Number";
            }
            */
            bool isEven = number % 2 == 0;
            bool isDivByFive = number % 5 == 0;
            bool isBig = number > 100; 

            if (isEven && isDivByFive && isBig)
            {
                returnString = "Big Even Number";
            }
            else if (isBig)
            {
                returnString = "Big Number";
            }

            return returnString;
        }
        


    }
}
