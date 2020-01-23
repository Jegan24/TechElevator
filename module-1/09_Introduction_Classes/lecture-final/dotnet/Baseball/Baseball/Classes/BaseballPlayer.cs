using System;
using System.Collections.Generic;
using System.Text;

namespace Baseball.Classes
{
    class BaseballPlayer
    {
        public string FirstName { get;  }
        public int TimesAtBat { get; set; }
        public int NumHits { get; set; }

        public double BattingAverage
        {
            get
            {
                return (double)NumHits / TimesAtBat;
            }
        }
        public string FormattedBattingAverage
        {
            get
            {
                double battingAverage = BattingAverage;
                string strBA = "" + battingAverage;
                if (battingAverage < 1) //don't change 1 to 1000
                {
                    strBA += "00000";//this will handle if it's .1 so we can get the substrign
                }
                else
                {
                    strBA += ".000";
                }

                string toReturn = strBA.Substring(0, 5);
                return toReturn;
            }
        }

        public BaseballPlayer(string name)
        {
            FirstName = name;
        }

        /* not needed since we are using .NET properties
        public string getFirstName()
        {
            return firstName; 
        }
        public void setFirstName(string n)
        {
            firstName = n;
        }
        */
    }
}
