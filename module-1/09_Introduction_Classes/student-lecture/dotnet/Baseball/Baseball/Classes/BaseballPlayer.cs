using System;
using System.Collections.Generic;
using System.Text;

namespace Baseball.Classes
{
    class BaseballPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int TimesAtBat { get; set; }
        public int NumHits { get; set; }

        public double BattingAverage
        {
            get
            {
                return TimesAtBat != 0 ? 1.0 * NumHits / TimesAtBat : 0;
            }
        }

        public string FormattedBattingAverage
        {
            get
            {
                return this.BattingAverage.ToString(".000");
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public BaseballPlayer()
        {

        }

        public override string ToString()
        {
            return this.FirstName;
        }
    }
}
