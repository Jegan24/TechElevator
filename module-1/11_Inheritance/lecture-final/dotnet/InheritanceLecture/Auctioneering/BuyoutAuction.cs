using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// a buyout auction has a price that the bidder can use allowing the auction to end
    /// </summary>
    public class BuyoutAuction : Auction
    {
        private int buyoutPrice; 
        public int BuyoutPrice
        {
            get
            {
                return buyoutPrice; 
            }
        }


        //if i don't explicitly call a parent constructor, compiler calls the default no-arg constructor first
        public BuyoutAuction(int buyoutPrice) : this (buyoutPrice,"BuyoutAuction")
        {
            this.buyoutPrice = buyoutPrice;
            Console.WriteLine("In buyout Constructor");
        }

        public BuyoutAuction(int buyoutPrice, string name) : base(name)
        {
            this.buyoutPrice = buyoutPrice;
            Console.WriteLine("In buyout Constructor");
        }

        public void KatieAutoBid()
        {
            Bid katieBid = new Bid("Katie", 50);
            base.PlaceBid(katieBid);
        }

        public override bool PlaceBid(Bid offeredBid)
        {
            bool isCurrentWinningBid = false;
            //return base.PlaceBid(offeredBid);

            if (!HasEnded)//if the auction is still going on
            {
                //if the offered bid amount is highter than the buyout price
                if (offeredBid.BidAmount >= buyoutPrice)
                {
                    Bid newBid = new Bid(offeredBid.Bidder, buyoutPrice);
                    base.PlaceBid(newBid);
                    Console.WriteLine("Buyout met by " + newBid.Bidder);
                    base.EndAuction();
                    isCurrentWinningBid = true;
                }
                else
                {
                    isCurrentWinningBid = base.PlaceBid(offeredBid);
                }

               
            }


            return isCurrentWinningBid;
        }
    }
}
