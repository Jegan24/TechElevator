using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp = getTempature();
            double tempF;
            double tempC;
            bool isCelcius = getIsCelcius();
            if(isCelcius)
            {
                tempC = temp;
                tempF = convertToFarenheit(tempC);
                Console.WriteLine(tempC + "C is " + tempF + "F");
            }
            else
            {
                tempF = temp;
                tempC = convertToFarenheit(tempF);
                Console.WriteLine(tempF + "F is " + tempC + "C");
            }
        }

        public static double getTempature()
        {
            double tempature = 0;
            bool isValid = false;

            Console.Write("Please enter the temperature: ");
            do
            {
                string input = Console.ReadLine();

                if (double.TryParse(input, out tempature))
                {
                    isValid = true;                    
                }
                else
                {
                    Console.WriteLine("Please enter numeric values only");
                }

            }
            while (!isValid);

            return tempature;
        }

        public static bool getIsCelcius()
        {
            bool isCelcius = false;
            bool isValid = false;
            do
            {
                Console.Write("Is the temperature in (C)elsius, or (F)ahrenheit? ");
                string input = Console.ReadLine();
                input = input.Trim().ToUpper().Substring(0, 1);
                if(input.CompareTo("F") == 0)
                {
                    isValid = true;
                }
                else if(input.CompareTo("C") == 0)
                {
                    isCelcius = true;
                    isValid = true;
                }
                else
                {
                    Console.Write("Invalid Input");
                }
            }
            while (!isValid);
            return isCelcius;
        }

        public static double convertToFarenheit(double tempCelcius)
        {
            return tempCelcius * 1.8 + 32;
        }

        public static double convertToCelcius(double tempFarenheit)
        {
            return (tempFarenheit - 32) / 1.8;
        }
    }
}
