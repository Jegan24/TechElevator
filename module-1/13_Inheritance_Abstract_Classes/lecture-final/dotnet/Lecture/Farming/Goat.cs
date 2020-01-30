using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Goat : FarmAnimal
    {
        public Goat() : base("GOAT")
        { }

        public override string eat()
        {
            return "mmmm";
        }

        public override string MakeAwakeSoundOnce()
        {
            return "BLEAT";
        }

        /// <summary>
        /// The noise made when the farm animal makes its sound twice.
        /// </summary>
        /// <returns></returns>
        public override string MakeAwakeSoundTwice()
        {
            return "BLEAT BLEAT";
        }

    }
}
