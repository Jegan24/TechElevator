using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = getLength();
            double lengthFeet;
            double lengthMeters;
            bool isMeters = getIsMeters();
            if (isMeters)
            {
                lengthMeters = length;
                lengthFeet = convertToFeet(lengthMeters);
                Console.WriteLine(lengthMeters + "M is " + lengthFeet + "F");
            }
            else
            {
                lengthFeet = length;
                lengthMeters = convertToMeters(lengthFeet);
                Console.WriteLine(lengthFeet + "F is " + lengthMeters + "M");
            }
        }

        public static double getLength()
        {
            double length = 0;
            bool isValid = false;

            Console.Write("Please enter the length: ");
            do
            {
                string input = Console.ReadLine();

                if (double.TryParse(input, out length))
                {
                    if(length < 0)
                    {
                        Console.WriteLine("Value must be positive");
                    }
                    else
                    {
                        isValid = true;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Please enter numeric values only");
                }

            }
            while (!isValid);

            return length;
        }


        public static bool getIsMeters()
        {
            bool isMeters = false;
            bool isValid = false;
            do
            {
                Console.Write("Is the measurement in (M)eters, or (F)eet? ");
                string input = Console.ReadLine();
                input = input.Trim().ToUpper().Substring(0, 1);
                if (input.CompareTo("F") == 0)
                {
                    isValid = true;
                }
                else if (input.CompareTo("M") == 0)
                {
                    isMeters = true;
                    isValid = true;
                }
                else
                {
                    Console.Write("Invalid Input");
                }
            }
            while (!isValid);
            return isMeters;
        }

        public static double convertToFeet(double lengthMeters)
        {
            return lengthMeters * 3.2808399;
        }

        public static double convertToMeters(double lengthFeet)
        {
            return lengthFeet * 0.3048;
        }

    }
}
