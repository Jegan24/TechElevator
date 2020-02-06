using Module1Review.Classes;
using System;
using System.Collections.Generic;

namespace Module1Review
{
    class Program
    {
        private static string animal = "shark";
        static void Main(string[] args)
        {
            //NameThatTune();
            List<Student> myClassList = new List<Student>();
            Dictionary<string, Student> myClassDictionary = new Dictionary<string, Student>();

            Console.WriteLine("Enter student name");
            string name = Console.ReadLine();
            Student joe = new Student(name);
            joe.AddQuizScore(90);
            joe.AddQuizScore(40);

            myClassList.Add(joe);

            Student noName = new VIPStudent();
            myClassList.Add(noName);


            VIPStudent studentB = new VIPStudent("Xanth");
            studentB.AddQuizScore(100);
            studentB.AddQuizScore(85);
            myClassList.Add(studentB);

            PrintStudentInfo(myClassList);

            AddAllStudentsFromListIntoDictionary(myClassList, myClassDictionary);
            AskUserForStudentScore(myClassList);

        }

        private static void AddAllStudentsFromListIntoDictionary(List<Student> myClassList, Dictionary<string, Student> myClassDictionary)
        {
            foreach(Student s in myClassList)
            {
                myClassDictionary.Add(s.Name, s);
            }
        }

        private static void AskUserForStudentScore(List<Student> list,Dictionary<string,Student> dictionary)
        {
            Console.WriteLine("Enter student name who took a quiz:");
            string name = Console.ReadLine();

            int score = -1;
            while (score == -1)
            {
                try
                {
                    Console.WriteLine("Enter quiz score (must be int between 0 and 100");
                    //int.TryParse(Console.ReadLine(), out score); //redundant since we're in a try
                    score = int.Parse(Console.ReadLine() );


                    //score = int.Parse(Console.ReadLine());
                    if (score < 0 || score > 100)
                    {
                        score = -1;
                    }
                }
                catch (Exception e)
                {
                    //score = -1;
                }
            }

            //find the student in the list and then add the quiz score
            /* loop throug the list for the student name
            foreach(Student s in list)
            {
                if (s.Name == name)
                {
                    s.AddQuizScore(score);
                }
            }
            */
            if (dictionary.ContainsKey(name))
            {
                Student studentToUpdate = dictionary[name];
                studentToUpdate.AddQuizScore(score);
                //dictionary[name].AddQuizScore(score); all in one line
            }

        }

        private static void PrintStudentInfo(List<Student> myClass)
        {
            //print name and quiz score for my class
            foreach (Student s in myClass)
            {
                for (int i = 0; i < 3; i++)
                {
                    s.TakeQuiz();
                }
                Console.WriteLine($"{s.Name}'s average quiz score is {s.GetAverageQuizScore()}");
                int[] ar = s.QuizScores;
                Console.WriteLine(String.Join(", ", ar));
                foreach (int score in ar)
                {
                    Console.Write(score + ", ");
                }
                Console.WriteLine();
            }
        }

        public static void NameThatTune()
        {
            string[] ages = { "Baby", "Mama", "Daddy", "Grandma", "Grandpa" };
            foreach (string s in ages)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{s} {animal}");
                    string result = "";
                    for (int j = 0; j < 6; j++)
                    {
                        result += " doo";
                    }
                    Console.WriteLine(result);
                }
                Console.WriteLine($"{s} {animal}");
            }
        }
    }
}
