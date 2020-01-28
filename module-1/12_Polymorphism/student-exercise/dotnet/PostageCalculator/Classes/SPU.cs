using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPU : IDeliveryDriver
    {
        public double DeliveryRate { get; }
        public string Name { get; }
        public SPU(double deliveryRate, string name)
        {
            this.DeliveryRate = deliveryRate / 16;
            this.Name = "SPU (" + name + ")";
        }
        public double CalculateRate(int distance, double weight)
        {
            return distance * (DeliveryRate * weight);
        }
    }
}
