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
        15. Now, do it again with a different bool opeation.
        TOPIC: Logical Not
        */
        public string ReturnAdultOrMinorAgain(int number)
        {
            string output = "";
            if (!(number >= 18))
            {
                output = "Minor";
            }
            else
            {
                output = "Adult";
            }
            return output;
        }
    }
}
