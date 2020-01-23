using Baseball.Classes;
using System;
using System.Collections.Generic;

namespace Baseball
{
    class Program
    {
        static void Main(string[] args)
        {

            //This program will prompt the user for the number of players on the team
            //for each player, we will need their name, # times at bat and # of hits
            //then we'll display the player name and batting average for every player
            //then we'll display the player with the best batting average

            Console.WriteLine("How many players are on your team?");
            string strNumPlayers = Console.ReadLine();
            int numPlayers = int.Parse(strNumPlayers);
            while (numPlayers < 0 || numPlayers > 20)
            {
                Console.WriteLine("Invalid. Please enter number of players between 1 and 20.");
                strNumPlayers = Console.ReadLine();
                numPlayers = int.Parse(strNumPlayers);
            }

            List<BaseballPlayer> team = new List<BaseballPlayer>();

            for (int i = 0; i < numPlayers; i++)
            {
                team.Add(GetIndividualPlayerData());
            }


            BaseballPlayer best = FindBestBattingAverage(team);
           
            Console.WriteLine("Player with best average: "+ best.FirstName+ " Batting Average: "+best.FormattedBattingAverage);

        }

        private static BaseballPlayer FindBestBattingAverage( List<BaseballPlayer> team)
        {
            BaseballPlayer playerWithBestBattingAverage = null;
            
            foreach (BaseballPlayer checkThisOne in team)
            {                

                if (checkThisOne.BattingAverage > ( (playerWithBestBattingAverage==null)?0: playerWithBestBattingAverage.BattingAverage) )
                {
                    playerWithBestBattingAverage = checkThisOne;
                }

            }
            return playerWithBestBattingAverage;
        }

        private static BaseballPlayer GetIndividualPlayerData()
        {
           
            Console.WriteLine("Enter player name: ");
            string name = Console.ReadLine();
            BaseballPlayer bp = new BaseballPlayer(name);
            
            int numberOfHits = 0;
            do
            {
                Console.WriteLine("Times at bat must be less than number of hits.");

                Console.WriteLine("Enter times " + bp.FirstName + " has been at bat: ");
                string strTimesAtBat = Console.ReadLine();
                bp.TimesAtBat = int.Parse(strTimesAtBat);
                numberOfHits = bp.TimesAtBat + 1;

                Console.WriteLine("Enter number of hits: ");
                string strNumHits = Console.ReadLine();                 
                numberOfHits = int.Parse(strNumHits);              
                    
            }
            while   (numberOfHits > bp.TimesAtBat) ;

            bp.NumHits = numberOfHits;
             
            return bp;
        }


    }
}
