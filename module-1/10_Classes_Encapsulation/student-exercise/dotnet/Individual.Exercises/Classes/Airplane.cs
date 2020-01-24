using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        #region Properties
        public string PlaneNumber { get; }
        public int TotalFirstClassSeats { get; }
        public int TotalCoachSeats { get; }
        public int BookedFirstClassSeats { get; private set; }
        public int BookedCoachSeats { get; private set; }
        public int AvailableFirstClassSeats
        {
            get
            {
                return TotalFirstClassSeats - BookedFirstClassSeats;
            }
        }
        public int AvailableCoachSeats 
        {
            get
            {
                return TotalCoachSeats - BookedCoachSeats;
            }
        }
        #endregion

        #region Constructors
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;
        }
        #endregion

        #region Methods
        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            bool output = false;
            if (forFirstClass && AvailableFirstClassSeats >= totalNumberOfSeats)
            {
                BookedFirstClassSeats += totalNumberOfSeats;
                output = true;
            }
            else if(!forFirstClass && AvailableCoachSeats >= totalNumberOfSeats)
            {
                BookedCoachSeats += totalNumberOfSeats;
                output = true;
            }
            return output;
        }
        #endregion
    }
}
