using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    class Truck : IVehicle
    {
        public int NumberOfAxles { get; }
        public int DistanceTraveled { get; set; }
        public double Toll { get; set; }
        public Truck(int numberOfAxles)
        {
            this.NumberOfAxles = numberOfAxles;
        }
        public double CalculateToll(int distance)
        {
            double ratePerMile = 0.0;
            DistanceTraveled = distance;
            if (NumberOfAxles == 4)
            {
                ratePerMile = .04;
            }
            else if(NumberOfAxles == 6)
            {
                ratePerMile = .045;
            }
            else if(NumberOfAxles >= 8)
            {
                ratePerMile = .048;
            }

            Toll = ratePerMile * distance;
            return Toll;
        }

        public string GetFancyString()
        {
            return String.Format("{0,-30} {1,-20} {2, -5}", $"Truck ({NumberOfAxles} Axles)", DistanceTraveled, Toll.ToString("C"));
        }
    }
}
