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
            Name = "gary"; //i can change this here since Name lives in FarmAnimal and is protected set
        }

        public void reNameTheGoose(string newName)
        {
            Name = newName; 
        }

        public override string MakeAwakeSoundOnce()
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
        public override string MakeAwakeSoundTwice()
        {
            return "HONK HONK";
        }

        public override string eat()
        {
            return "mmmm";
        }
    }
}
