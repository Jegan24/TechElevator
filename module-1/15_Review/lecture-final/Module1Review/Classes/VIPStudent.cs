using System;
using System.Collections.Generic;
using System.Text;

namespace Module1Review.Classes
{
    public class VIPStudent : Student
    {
        //this class to return name + " the Magnificent" for the name
        public override string Name { 
            get
            {
                return base.Name + " the Magnificent"; 
            }
        }

        public VIPStudent(string name) : base(name)
        {
            quizScores.Add(100);
        }
        public VIPStudent() { }

        public override void TakeQuiz()
        {
            //generate a random number between 0 and 100
            int score = random.Next(70, 100);

            //add as a quiz score
            AddQuizScore(score);
        }
    }
}
