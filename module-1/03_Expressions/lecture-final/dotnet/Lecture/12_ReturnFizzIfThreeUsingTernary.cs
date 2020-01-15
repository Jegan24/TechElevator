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
        12. Now write the above using the Ternary operator ?:
         returns "Fizz" 
            if the parameter is 3 and returns an empty string for anything else.
        */
        public string ReturnFizzIfThreeUsingTernary(int number)
        {
            //(some condition)? <use this if true>:<use this if false>
            return (number == 3) ? "Fizz" : "";
                 
        }
    }
}
