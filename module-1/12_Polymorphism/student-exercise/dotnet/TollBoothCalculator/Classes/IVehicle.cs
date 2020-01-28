using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    interface IVehicle
    {
        int DistanceTraveled { get; set; }
        double Toll { get; set; }
        double CalculateToll(int distance);

        string GetFancyString();
    }
}
