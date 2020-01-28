using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    class Tank : IVehicle
    {
        public int DistanceTraveled { get; set; }
        public double Toll { get; set; }
        public double CalculateToll(int distance)
        {
            DistanceTraveled = distance;
            Toll = 0;
            return Toll;
        }

        public string GetFancyString()
        {
            return String.Format("{0,-30} {1,-20} {2, -5}", "Tank", DistanceTraveled, Toll.ToString("C"));
        }
    }
}
