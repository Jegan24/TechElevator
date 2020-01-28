using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Goose : FarmAnimal, ISellable
    {
        public double Cost { get; set; }

        public Goose(): base("goose") 
        { }

        public void nameTheGooseGary()
        {
            Name = "gary";
        }

        public void reNameTheGoose(string newName)
        {
            Name = newName; 
        }

        public override string MakeSoundOnce()
        {
            return "HONK";
        }

        public string MakeSoundOnce(string noise) //overloaded, NOT OVERRIDDEN and does not satisfy the interface contract
        {
            return noise; 
        }

        /// <summary>
        /// The noise made when the farm animal makes its sound twice.
        /// </summary>
        /// <returns></returns>
        public override string MakeSoundTwice()
        {
            return "HONK HONK";
        }
    }
}
