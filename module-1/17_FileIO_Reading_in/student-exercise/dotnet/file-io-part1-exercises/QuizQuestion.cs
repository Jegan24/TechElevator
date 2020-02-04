using System;
using System.Collections.Generic;
using System.Text;

namespace file_io_part1_exercises
{
    class QuizQuestion
    {
        public string Question { get; }
        public Dictionary<int,string> Answers { get; private set; }
        public int CorrectAnswerNumber { get; }
        public QuizQuestion (string question, List<string>answers, int correctAnswerNumber)
        {
            Answers = new Dictionary<int, string>();
            Question = question;
            int questionNumber = 1;
            foreach(string answer in answers)
            {
                Answers[questionNumber] = answer;
                questionNumber++;
            }

            CorrectAnswerNumber = correctAnswerNumber;
            Answers[CorrectAnswerNumber] = Answers[CorrectAnswerNumber].Replace("*", "");
        }
    }
}
