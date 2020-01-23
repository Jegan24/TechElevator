using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {
        public string Name { get; set; }
        public int NumberOfEmployees { get; set; }
        public decimal Revenue { get; set; }
        public decimal Expenses { get; set; }
        public Company()
        {

        }

        public string GetCompanySize()
        {
            string output = "small";
            if(NumberOfEmployees > 250)
            {
                output = "large";
            }
            else if(NumberOfEmployees >= 50)
            {
                output = "medium";
            }
            return output;
        }

        public decimal GetProfit()
        {
            return Revenue - Expenses;
        }
    }
}
