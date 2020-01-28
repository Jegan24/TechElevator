using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    class Car : IVehicle
    {
        public bool HasTrailer { get; }
        public int DistanceTraveled { get; set; }
        public double Toll { get; set; }
        public Car(bool hasTrailer)
        {
            this.HasTrailer = hasTrailer;
        }

        public double CalculateToll(int distance)
        {
            DistanceTraveled = distance;
            Toll = distance * .02 + (HasTrailer ? 1 : 0);
            return Toll;
        }

        public string GetFancyString()
        {
            string name = "Car" + (HasTrailer ? " (With Trailer)" : "");

            return String.Format("{0,-30} {1,-20} {2, -5}", name, DistanceTraveled, Toll.ToString("C"));
        }
    }
}
