using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fileContents;
            Queue<List<string>> newFiles = new Queue<List<string>>();
            string originalFilePath;
            string originalFileName;
            string directory;
            int maxFileSize;

            originalFilePath = GetFilePath();
            if (originalFilePath.Length > 0)
            {
                maxFileSize = GetMaxFileSize();
                fileContents = ReadFile(originalFilePath);
                directory = originalFilePath.Substring(0, originalFilePath.LastIndexOf("\\") + 1);
                originalFileName = originalFilePath.Substring(originalFilePath.LastIndexOf("\\"));
                originalFileName = originalFileName.Remove(originalFileName.IndexOf("."));
                CreateNewFiles(fileContents, newFiles, maxFileSize);
                WriteNewFiles(newFiles, originalFileName, directory);
            }

        }

        public static string GetFilePath()
        {
            string filePath = "";
            bool isValidFilePath;

            Console.WriteLine("Where is the input file (please include the path to the file) ");
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
        public static bool ValidateFilePath(string filePath)
        {
            bool isValid = File.Exists(filePath);
            return isValid;
        }

        public static int GetMaxFileSize()
        {
            int maxSize = 0;
            string input;
            Console.Write("How many lines of text (max) should there be in the split files? ");
            input = Console.ReadLine();
            if (!(int.TryParse(input, out maxSize)) || maxSize < 1)
            {
                Console.WriteLine("Please enter a number greater than 0");
                maxSize = GetMaxFileSize();
            }
            return maxSize;
        }

        public static Queue<string> ReadFile(string filePath)
        {
            Queue<string> fileContents = new Queue<string>();
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
                        fileContents.Enqueue(sr.ReadLine());
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

        public static void CreateNewFiles(Queue<string> originalFile, Queue<List<string>> newFiles, int maxFileSize)
        {
            while (originalFile.Count > 0)
            {
                newFiles.Enqueue(CreateNewFileChunk(originalFile, maxFileSize));
            }
        }

        public static List<string> CreateNewFileChunk(Queue<string> originalFile, int maxFileSize)
        {
            List<string> fileChunk = new List<string>();
            int stoppingPoint = maxFileSize > originalFile.Count ? originalFile.Count : maxFileSize;
            for (int i = 0; i < stoppingPoint; i++)
            {
                fileChunk.Add(originalFile.Dequeue());
            }
            return fileChunk;
        }

        public static void WriteNewFiles(Queue<List<string>> newFiles, string originalFileName, string directory)
        {
            int fileCounter = 1;

            while (newFiles.Count > 0)
            {
                WriteNewFile(newFiles.Dequeue(), fileCounter, originalFileName, directory);
                fileCounter++;
            }
        }

        public static void WriteNewFile(List<string> newFile, int fileNumber, string originalFileName, string directory)
        {

            using (StreamWriter sw = new StreamWriter($"{directory}{originalFileName}-{fileNumber}.txt", false))
            {
                foreach (string line in newFile)
                {
                    sw.WriteLine(line);
                }
            }
        }
    }
}
