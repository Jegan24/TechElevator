using System;
using System.Collections.Generic;


namespace HashSetCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> jerseyNumbers = new HashSet<int>();
            Console.WriteLine("Enter jersey number. Enter q to quit");
            string input = Console.ReadLine().ToLower();
            while (input != "q")
            {
                //parse input into a number
                int num = int.Parse(input);

                //see if it's already taken in our hashset
                if (jerseyNumbers.Contains(num))
                {
                    Console.WriteLine($"Sorry. {num} is already taken.");
                }
                else //add if not
                {
                    Console.WriteLine($"You get number {num}. Congrats");
                }
                jerseyNumbers.Add(num);

                Console.WriteLine("Enter jersey number. Enter q to quit");
                input = Console.ReadLine().ToLower();
            }
        }
    }
}
