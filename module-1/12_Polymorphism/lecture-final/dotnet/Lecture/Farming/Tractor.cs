using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : ISingable,ISellable
    {
        public double Cost { get; set; }
        public string Name { get; private set; }

        public Tractor()
        {
            Name = "Tractor";
        }

        public string MakeSoundOnce()
        {
            return "Vroom";
        }

        public string MakeSoundTwice()
        {
            return "Vrooom Vroom";
        }

        public void reNameIt(string newName)
        {
            Name = newName;
        }
    }
}
