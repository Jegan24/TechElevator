using System;
using System.Collections.Generic;
using System.Linq;
using PostageCalculator.Classes;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeliveryDriver> deliveryMethods = new List<IDeliveryDriver>();
            double weight = GetWeightFromUser();
            int distance = GetDistanceFromUser();
            deliveryMethods.Add(new PostalServiceClass(0.035, 0.040, 0.047, 0.195, 0.450, 0.500, "1st Class"));
            deliveryMethods.Add(new PostalServiceClass(0.0035, 0.0040, 0.0047, 0.0195, 0.0450, 0.0500, "2nd Class"));
            deliveryMethods.Add(new PostalServiceClass(0.0020, 0.0022, 0.0024, 0.0150, 0.0160, 0.0170, "3rd Class"));
            deliveryMethods.Add(new FexEd("FexEd"));
            deliveryMethods.Add(new SPU(0.0050, "4-Day Ground"));
            deliveryMethods.Add(new SPU(0.0500, "2-Day Business"));
            deliveryMethods.Add(new SPU(0.0750, "Next Day"));

            Console.WriteLine("\n" + String.Format("{0,-40} {1,-5}", "Delivery Method", "$ cost"));
            string line = "-";
            while (line.Length < 47)
            {
                line += "-";
            }
            Console.WriteLine(line);
            foreach (IDeliveryDriver deliveryDriver in deliveryMethods)
            {
                //Console.WriteLine($"{deliveryDriver.Name}\t{deliveryDriver.CalculateRate(distance, weight).ToString("C")}");
                Console.WriteLine(String.Format("{0,-40} {1,-5}", deliveryDriver.Name, deliveryDriver.CalculateRate(distance, weight).ToString("C")));
            }

        }

        public static double GetWeightFromUser()
        {
            double weight = 0;
            string input = "";
            while (weight <= 0)
            {
                Console.Write("Please enter the weight of the package: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out weight))
                {
                    if(weight <= 0)
                    {
                        Console.WriteLine("Weight must be positive");
                    }
                }
                else
                {
                    Console.WriteLine("Enter numeric values only");
                }
            }
            do
            {
                Console.Write("(P)ounds or (O)unces? ");
                input = Console.ReadLine();
                if(input.ToUpper() == "O" || input.ToUpper() == "P")
                {
                    if(input.ToUpper() == "P")
                    {
                        weight *= 16;
                    }
                    break;
                }
            }
            while (true);
            return weight;
        }
        public static int GetDistanceFromUser()
        {
            int distance = 0;
            string input = "";
            while (distance <= 0)
            {
                Console.Write("What distance will it be traveling? ");
                input = Console.ReadLine();
                if (int.TryParse(input, out distance))
                {
                    if (distance <= 0)
                    {
                        Console.WriteLine("Distance must be positive");
                    }
                }
                else
                {
                    Console.WriteLine("Enter integer values only");
                }
            }
            return distance;
        }
    }
}
