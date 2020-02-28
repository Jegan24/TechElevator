using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechElevator.Web.Models
{
    public class Cookie
    {
        public string Type { get; }
        public int numCalories { get; }

        public Cookie(string type, int nc)
        {
            Type = type;
            numCalories=nc;
                 
        }
    }
}
