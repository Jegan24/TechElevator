using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Apple : ISellable
    {
        public double Cost { get; set; } = 1; 

        public string Name { get; set; } = "Apple";
    }
}
