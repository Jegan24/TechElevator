using System;
using System.IO;

namespace EncryptTheFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //we want to prompt the user for a file name to encrypt
            Console.WriteLine("Please enter a file to encrypt:");
            string userPath = Console.ReadLine();

            while (!File.Exists(userPath)) //reprompt if the file doesn't exist
            {
                Console.WriteLine("Invalid file. Please enter a file to encrypt:");
                userPath = Console.ReadLine();
            }

            //prompt for the number of spaces to shift
            Console.WriteLine("Enter number of spaces to shift: ");
            int shift = 0;
            while (shift == 0)
            {
                try
                {
                    shift = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input. Enter a non-zero number.");
                }
            }

            //remove the extension and then add -encrypted plus the extension again
            FileInfo fi = new FileInfo(userPath);


            string outputFile = Path.Combine(fi.Directory.FullName,  Path.GetFileNameWithoutExtension(fi.Name) + "-encrypted" + fi.Extension) ; 
            

            //encrypt the file with the shift and write to output file inputname-encrypted.txt
            using (StreamReader sr  = new StreamReader(userPath))
            {
                using (StreamWriter sw = new StreamWriter(outputFile, false))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string encryptedLine = EncryptLine.Encrypt(line, shift);
                        sw.WriteLine(encryptedLine);
                    }

                }
            }


        }
    }
}
