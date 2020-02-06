using System;
using System.Collections.Generic;
using System.Text;

namespace Module1Review.Classes
{
    public class Student
    {
        protected List<int> quizScores = new List<int>();
        protected static Random random = new Random();

        public int[] QuizScores { 
            get
            {
                return quizScores.ToArray();
            }
        }

        public virtual string Name { get;  }

        public void AddQuizScore(int score)
        {
            if (score >= 0 && score <= 100)
            {
                quizScores.Add(score);
            }
           
        }

        public Student()
        {

        }

        public Student(string name)
        {
            Name = name;
        }

        public double GetAverageQuizScore()
        {
            if (quizScores.Count == 0)
            {
                return 0;
            }
            double sum = 0;
            foreach (int score in quizScores)
            {
                sum += score;
            }
            return sum / quizScores.Count;
        }

        public virtual void TakeQuiz()
        {
            //generate a random number between 0 and 100
            int score = random.Next(0, 100);

            //add as a quiz score
            AddQuizScore(score);
        }
    }
}
