using System;
using System.IO;
using Lecture.Aids;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here are a few examples of reading in a file and writing out values
            // to demonstrate their value.
            //ReadingInFiles.ReadACharacterFile();
            //ReadingInFiles.ReadInACSVFile();  
            //WritingTextFiles.WritingAFile();
            //LoopingCollectionToWriteFile.LoopingADictionaryToWriteAFile();
            //BinaryFileWriter.WritePrimitiveValues();
            //BinaryFileWriter.ReadPrimitiveValues();
            //ReadingAndWritingFiles.OpenAndWrite();
            //BinaryImageManipulator.ReadFileIn();
            PerformanceDemo.SlowPerformance();
            PerformanceDemo.FastPerformance();

            FileInfo f = new FileInfo(@"C:\Users\Katie Dwyer\BitBucket\c-main\module-1\18_FileIO_Writing_out\lecture-final\dotnet\Lecture\bin\Debug\netcoreapp2.1\fast-file.txt");
            Console.WriteLine($"{f.Name} was created at {f.CreationTime}");

            // Students find value in building something useful. 
            // As a group you could build something that prompts the user for data and saves it to a file.
            // OR reads a file in and "processes" the data (geocoding?)

            Console.Write("Press enter to finish");
            Console.ReadLine();
        }
    }
}
