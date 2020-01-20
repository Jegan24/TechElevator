using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a non-empty string like "Code" return a string like "CCoCodCode".
                                        0123                        0010120123
         StringSplosion("Code") → "CCoCodCode"
         StringSplosion("abc") → "aababc"
         StringSplosion("ab") → "aab"
         */
        public string StringSplosion(string str)
        {
            string s = "";
            for (int i = 1; i <= str.Length; i++)
            {
                s += str.Substring(0, i);
            }
            //for (int i = 1; i <= str.Length; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        s += str.Substring(j, 1);
            //    }

            //}
            return s;
        }
    }
}
