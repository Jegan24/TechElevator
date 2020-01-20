﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return a version without both the first and last char of the string. The string
         may be any length, including 0.
         WithoutEnd2("Hello") → "ell"
         WithoutEnd2("abc") → "b"
         WithoutEnd2("ab") → ""
         */
        public string WithoutEnd2(string str)
        {
            string output;

            if(str.Length <= 2)
            {
                output = "";
            }
            else if(str.Length == 3)
            {
                output = str.Substring(1, 1);
            }
            else
            {
                output = str.Substring(1, str.Length - 2);
            }

            return output;
        }
    }
}
