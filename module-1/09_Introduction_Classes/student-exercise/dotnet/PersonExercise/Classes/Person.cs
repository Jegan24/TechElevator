using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Person
    {
        //Class Code Goes Here
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person()
        {

        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public bool IsAdult()
        {
            return Age >= 18;
        }
    }
}
