using InheritanceLecture.Auctioneering;
using System;

namespace InheritanceLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new general auction
            Console.WriteLine("Starting a general auction");
            Console.WriteLine("-----------------");

            /*
            Auction generalAuction = new Auction();
            Console.WriteLine("general auction: " + generalAuction);

            generalAuction.PlaceBid(new Bid("Josh", 1));
            generalAuction.PlaceBid(new Bid("Fonz", 23));
            generalAuction.PlaceBid(new Bid("Rick Astley", 13));

            Console.WriteLine("Current high bid: "+generalAuction.CurrentHighBid);
            //....
            //....
            // This might go on until the auction runs out of time or hits a max # of bids
            */

            /*
            ReserveAuction a = new ReserveAuction(50);
            a.PlaceBid(new Bid("Zach", 2));
            a.PlaceBid(new Bid("Chaz", 3));
            a.PlaceBid(new Bid("NOel", 4));
            a.PlaceBid(new Bid("Caleb", 51));
            a.PlaceBid(new Bid("Xanth", 1000000));
            a.PlaceBid(new Bid("Allen", 1));
            */

            BuyoutAuction buyout = new BuyoutAuction(50);
            buyout.PlaceBid(new Bid("Zach", 2));
            buyout.PlaceBid(new Bid("Chaz", 3));
            buyout.PlaceBid(new Bid("NOel", 4));
            buyout.PlaceBid(new Bid("Caleb", 51));
            buyout.PlaceBid(new Bid("Xanth", 1000000));
            buyout.PlaceBid(new Bid("Allen", 1));

            BuyoutAuction katieBuyout = new BuyoutAuction(100,"Katies fantastic auction");
            Console.WriteLine("buyout name " + buyout.Name + "katieBuyout name is " + katieBuyout.Name);
        }
    }
}
