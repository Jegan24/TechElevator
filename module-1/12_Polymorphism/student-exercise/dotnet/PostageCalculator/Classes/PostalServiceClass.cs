using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class PostalServiceClass : IDeliveryDriver
    {
        public double RateForTwoOunces { get; }

        public double RateForEightOunces { get; }

        public double RateForFifteenOunces { get; }

        public double RateForFourtyEightOunces { get; }

        public double RateForOneTwentyEightOunces { get; }

        public double RateForHeavy { get; }

        public string Name { get; }

        public PostalServiceClass(double two, double eight, double fifteen, double fourtyEight, double oneTwentyEight, double heavy, string name)
        {
            this.RateForTwoOunces = two;
            this.RateForEightOunces = eight;
            this.RateForFifteenOunces = fifteen;
            this.RateForFourtyEightOunces = fourtyEight;
            this.RateForOneTwentyEightOunces = oneTwentyEight;
            this.RateForHeavy = heavy;
            this.Name = "Postal Service (" + name + ")";
        }

        public double CalculateRate(int distance, double weight)
        {
            double rate = 0;
            if (weight <= 2)
            {
                rate = distance * RateForTwoOunces;
            }
            else if (weight <= 8)
            {
                rate = distance * RateForEightOunces;
            }
            else if (weight <= 15)
            {
                rate = distance * RateForFifteenOunces;
            }
            else if (weight <= 48)
            {
                rate = distance * RateForFourtyEightOunces;
            }
            else if (weight <= 128)
            {
                rate = distance * RateForOneTwentyEightOunces;
            }
            else
            {
                rate = distance * RateForHeavy;
            }
            return rate;
        }
    }
}
