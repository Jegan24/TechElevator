using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    interface ISellable
    {
        double Cost { get; set; }
        string Name { get; }
    }
}
