using System;
using System.Collections.Generic;
using file_io_part1_exercises;
using System.IO;
namespace file_io_part1_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fileContents = null;
            List<QuizQuestion> quizQuestions = new List<QuizQuestion>();
            int quizScore = 0;
            try
            {
                fileContents = ReadFile();
            }
            catch
            {
                Console.WriteLine("Error reading file");
            }
            if(fileContents != null)
            {
                foreach (string line in fileContents)
                {
                    quizQuestions.Add(ConvertLineToQuizQuestion(line));
                }
                foreach(QuizQuestion question in quizQuestions)
                {
                    if (AskQuizQuestion(question))
                    {
                        quizScore++;
                    }
                }
                Console.WriteLine($"You got {quizScore} answer(s) correct out of the {quizQuestions.Count} question(s) asked");
            }
            
                  
        }

        public static List<string> ReadFile()
        {
            const string quizFilePath = @"C:\Users\Student\workspace\jegan-c\module-1\17_FileIO_Reading_in\student-exercise\dotnet\sample-quiz-file.txt";
            List<string> lines = new List<string>();
            try
            {
                //Open a StreamReader with the using statement
                using (StreamReader sr = new StreamReader(quizFilePath))
                {
                    // Read the file until the end of the stream is reached
                    // EndOfStream is a "marker" that the stream uses to determine 
                    // if it has reached the end
                    // As we read forward the marker moves forward like a typewriter.

                    while (!sr.EndOfStream)
                    {
                        lines.Add(sr.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(ex.Message);
            }
            return lines;
        }

        public static QuizQuestion ConvertLineToQuizQuestion(string line)
        {
            string question = line.Split("?")[0];
            List<string> answers = new List<string>(line.Split("?")[1].Split("|",StringSplitOptions.RemoveEmptyEntries));
            int correctAnswer = answers.IndexOf(answers.Find(answer => answer.Contains("*"))) + 1;

            return new QuizQuestion(question, answers, correctAnswer);
        }

        public static bool AskQuizQuestion(QuizQuestion question)
        {
            bool isCorrect = false;
            string response;
            int responseVal;
            Console.WriteLine(question.Question);
            foreach(int key in question.Answers.Keys)
            {
                Console.WriteLine($"{key}. {question.Answers[key]}");
            }

            Console.Write("Your answer: ");
            response = Console.ReadLine();
            if(int.TryParse(response, out responseVal))
            {
                if(responseVal == question.CorrectAnswerNumber)
                {
                    isCorrect = true;
                    Console.WriteLine("CORRECT!");
                }
                else
                {
                    Console.WriteLine("WRONG!");
                }
            }

            return isCorrect;
        }
    }
}
