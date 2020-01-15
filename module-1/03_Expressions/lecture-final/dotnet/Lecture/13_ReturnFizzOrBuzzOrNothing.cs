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
         13. Write an if/else statement that returns 
            "Fizz" if the parameter is 3, 
            "Buzz" if the parameter is 5 
            and an empty string "" for anything else.
            TOPIC: Conditional Logic
         */
        public string ReturnFizzOrBuzzOrNothing(int number)
        {
            string returnString = "";
            if (number==3)
            {
                returnString= "Fizz";
            }
            else if (number==5)
            {
                returnString= "Buzz";
            }
            //this last else is optional since i set it to the empty string on line 21
            else
            {
                returnString= ""; 
            }
            return returnString;
        }
    }
}
