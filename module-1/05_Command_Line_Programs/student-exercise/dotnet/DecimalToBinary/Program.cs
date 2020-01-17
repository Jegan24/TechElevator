using System;
using System.Text;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = getValues();
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            for(int i = 0; i < values.Length; i++)
            {
                sb.Append(values[i] + " in binary is: " + ConvertNumberToBinary(values[i]) + "\n");
            }
            Console.WriteLine(sb.ToString());
        }

        public static int[] getValues()
        {
            int[] values;
            string input;
            string[] splitValues;
            bool isValid = false;
            Console.WriteLine("Please enter in a series of decimal values (separated by spaces): ");

            do
            {
                input = Console.ReadLine();
                bool isNumeric = true;
                while (input.Contains("  ")) { input = input.Replace("  ", " "); }
                splitValues = input.Split(" ");

                values = new int[splitValues.Length];
                for (int i = 0; i < splitValues.Length; i++)
                {
                    if (!(int.TryParse(splitValues[i], out values[i])))
                    {
                        isNumeric = false;
                        break;
                    }
                }
                if (!isNumeric)
                {
                    Console.WriteLine("Please only enter numeric values.");
                }
                else
                {
                    isValid = true;
                }


            }
            while (!isValid);

            return values;
        }


        private static string ConvertNumberToBinary(int base10)
        {
            string binary = "";
            while (base10 > 0)
            {
                binary = (base10 % 2) + binary;
                base10 = base10 / 2;
            }

            return binary;
        }
    }
}
