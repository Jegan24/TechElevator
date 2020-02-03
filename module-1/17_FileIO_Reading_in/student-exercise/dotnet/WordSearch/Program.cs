using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for the search string
            //2. Ask the user for the file path
            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number
            string searchString = GetSearchString();
            string filePath = GetFilePath();
            bool isCaseSensitive = GetIsCaseSensitive();
            Dictionary<int, string> fileContents = new Dictionary<int, string>();
            List<string> linesToPrint = new List<string>();
            if (filePath.Length > 0)
            {
                fileContents = ReadFile(filePath);
                                                                                    // get the keyValuePairs where the value contains searchString, adjusts for case sensitivity with ternary 
                foreach (KeyValuePair<int, string> keyValuePair in fileContents.Where(kvp => isCaseSensitive ? kvp.Value.Contains(searchString) :
                                                                                                               kvp.Value.ToUpper().Contains(searchString.ToUpper())
                                                                                                               ))                                                                                    
                {
                    if(isCaseSensitive ? keyValuePair.Value.Split(" ").Contains(searchString) : keyValuePair.Value.ToUpper().Split(" ").Contains(searchString.ToUpper())) // prevents partial matches ie: search word: who, match: whole
                    {
                        linesToPrint.Add(keyValuePair.Key.ToString() + ") " + keyValuePair.Value);
                    }                    
                }
                foreach (string line in linesToPrint)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public static string GetSearchString()
        {
            Console.Write("What is the search word you are looking for? ");
            return Console.ReadLine();
        }

        public static string GetFilePath()
        {
            string filePath = "";
            bool isValidFilePath;

            Console.WriteLine("What is fully qualified name of the file that should be searched?");
            filePath = Console.ReadLine();

            isValidFilePath = ValidateFilePath(filePath);

            if (!isValidFilePath)
            {
                // to do
                Console.WriteLine("The specified file path was invalid, would you re-enter it? Y/N");
                string response = Console.ReadLine();
                if (response.ToUpper() == "Y")
                {
                    filePath = GetFilePath();
                }
                else
                {
                    filePath = "";
                }
            }

            return filePath;
        }

        public static bool GetIsCaseSensitive()
        {
            bool isCaseSensitive;
            Console.WriteLine("Case sensitive? Y/N");
            string response;
            do
            {
                response = Console.ReadLine();
                if (response.ToUpper() == "Y")
                {
                    isCaseSensitive = true;
                }
                else
                {
                    isCaseSensitive = false;
                }
            }
            while (response.ToUpper() != "Y" && response.ToUpper() != "N");
            if (response.ToUpper() == "Y")
            {
                isCaseSensitive = true;
            }
            else
            {
                isCaseSensitive = false;
            }
            return isCaseSensitive;
        }

        public static bool ValidateFilePath(string filePath)
        {
            bool isValid = File.Exists(filePath);
            return isValid;
        }

        public static Dictionary<int, string> ReadFile(string filePath)
        {
            Dictionary<int, string> fileContents = new Dictionary<int, string>();
            int lineNumber = 0;
            try
            {
                //Open a StreamReader with the using statement
                using (StreamReader sr = new StreamReader(filePath))
                {
                    // Read the file until the end of the stream is reached
                    // EndOfStream is a "marker" that the stream uses to determine 
                    // if it has reached the end
                    // As we read forward the marker moves forward like a typewriter.

                    while (!sr.EndOfStream)
                    {
                        lineNumber++;
                        fileContents[lineNumber] = sr.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(ex.Message);
            }

            return fileContents;
        }


    }
}
