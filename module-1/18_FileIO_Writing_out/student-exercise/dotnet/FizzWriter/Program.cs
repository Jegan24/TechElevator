using System;
using System.IO;
using System.Collections.Generic;

namespace FizzWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string contents = GetFileContents();

            WriteToFile(contents);
        }

        public static string GetFileContents()
        {
            string output = "";

            for (int i = 1; i < 301; i++)
            {
                output += FizzBuzz(i);
                if (i < 300)
                {
                    output += "\n";
                }
            }

            return output;
        }

        public static string FizzBuzz(int number)
        {
            string output = number.ToString();
            bool fizz = false;
            bool buzz = false;

            if (number.ToString().Contains("3") || number % 3 == 0)
            {
                fizz = true;
            }

            if (number.ToString().Contains("5") || number % 5 == 0)
            {
                buzz = true;
            }

            if (number % 5 == 0 && number % 3 == 0)
            {
                output = "FizzBuzz";
            }
            else if (fizz)
            {
                output = "Fizz";
            }
            else if (buzz)
            {
                output = "Buzz";
            }

            return output;
        }

        public static void WriteToFile(string contents)
        {
            string destinationDirectory = GetDestinationDirectory();
            string destination = Path.Combine(destinationDirectory, "FizzBuzz.txt");
            using (StreamWriter sw = new StreamWriter(destination, false))
            {
                sw.WriteLine(contents);
            }

        }
        public static string GetDestinationDirectory()
        {
            string directory = Directory.GetCurrentDirectory();
            List<string> directoryContents = new List<string>(Directory.GetFiles(directory));

            while (directoryContents.FindAll(readme => readme.Contains("README.md")).Count < 1)
            {
                directory = Directory.GetParent(directory).FullName;
                directoryContents = new List<string>(Directory.GetFiles(directory));
            }

            return directory;
        }
    }
}
