using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Goat : FarmAnimal
    {
        public Goat() : base("GOAT")
        { }

        public override string MakeSoundOnce()
        {
            return "BLEAT";
        }

        /// <summary>
        /// The noise made when the farm animal makes its sound twice.
        /// </summary>
        /// <returns></returns>
        public override string MakeSoundTwice()
        {
            return "BLEAT BLEAT";
        }

    }
}
