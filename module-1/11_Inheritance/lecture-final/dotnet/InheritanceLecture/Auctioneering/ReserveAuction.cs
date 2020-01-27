using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// A reserve auction has a minimum reserve price that must be met before the bid
    /// is considered worthy and logged
    /// </summary>
    public class ReserveAuction : Auction
    {
        private int reservePrice;

        public ReserveAuction(int reservePrice):base("Reserve Auction")
        {
            this.reservePrice = reservePrice; 
        }

        public override bool PlaceBid(Bid offeredBid)
        {
            bool isCurrentWinningBid = false;
            if (offeredBid.BidAmount >= reservePrice)
            {
                isCurrentWinningBid = base.PlaceBid(offeredBid);
            }
            else 
            {
                Console.WriteLine("Reserve not met");
            }
            
            return isCurrentWinningBid;
        }
    }
}
