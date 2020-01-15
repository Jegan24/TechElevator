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
        10.This method will take a number and do the following things to it:
            If addThree is true, we'll add three to that number
            If addFive is true, we'll add five to that number
            We'll then return the result
            TOPIC: Stacking Conditional Logic
            (2,false,false)-> 2
            (2,false,true) -> 7
            (2,true,false)->5
            (2,true,true)->10

            to call this method 
            ReturnNumberAfterAddThreeAndAddFive(2,false,false)
        */
        public int ReturnNumberAfterAddThreeAndAddFive(int number, bool addThree, bool addFive)
        {
            if (addThree)
            {
                number = number + 3;
            }

            // Why can't we use an else here?

            if (addFive)
            {
                number += 5;
            }

            return number;
        }
    }
}
