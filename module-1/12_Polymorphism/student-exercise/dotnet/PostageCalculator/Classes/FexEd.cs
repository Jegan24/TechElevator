using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class FexEd : IDeliveryDriver
    {
        public string Name { get; }

        public FexEd(string name)
        {
            this.Name = name;
        }
        public double CalculateRate(int distance, double weight)
        {
            return 20 + (distance > 500 ? 5 : 0) + (weight > 48 ? 3 : 0);
        }
    }
}
