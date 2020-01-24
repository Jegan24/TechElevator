using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        #region Properties
        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; }
        public string SubmitterName { get; }
        public string LetterGrade
        {
            get
            {
                double grade = ((double)EarnedMarks / PossibleMarks) * 100.0;
                string output = "";

                if (grade >= 90)
                {
                    output = "A";
                }
                else if (grade >= 80)
                {
                    output = "B";
                }
                else if (grade >= 70)
                {
                    output = "C";
                }
                else if (grade >= 60)
                {
                    output = "D";
                }
                else
                {
                    output = "F";
                }

                return output;
            }
        }
        #endregion

        #region Constructors
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;
        }
        #endregion

        #region Methods
        #endregion
    }
}
