using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNumber = 0;
            int currentNumber = 1;
            int limit = getLimit();
            const int largestFibonacciInteger = 1836311903;
            List<int> fibNumbers = new List<int>();
            StringBuilder sb = new StringBuilder();
            fibNumbers.Add(0);
            fibNumbers.Add(1);
            while((currentNumber+lastNumber) < limit && currentNumber < largestFibonacciInteger)
            {
                int newNumber = lastNumber + currentNumber;
                lastNumber = currentNumber;
                fibNumbers.Add(newNumber);
                currentNumber = newNumber;
            }

            for(int i =0; i < fibNumbers.Count; i++)
            {
                if(i % 10 == 0)
                {
                    sb.Append("\n");
                }
                sb.Append(fibNumbers[i]);
                if(!(i+1 == fibNumbers.Count))
                {
                    sb.Append(", ");
                }
            }
            
            Console.WriteLine(sb.ToString());

        }

        public static int getLimit()
        {
            int limit = 0;
            bool isValid = false;
            Console.Write("Please enter the Fibonacci number: ");
            do
            {
                string input = Console.ReadLine();
                if(int.TryParse(input, out limit))
                {
                    if(limit > 0)
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Number must be greater than 0");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter whole numbers only");
                }
            } while (!isValid);

            return limit;
        }
    }
}
