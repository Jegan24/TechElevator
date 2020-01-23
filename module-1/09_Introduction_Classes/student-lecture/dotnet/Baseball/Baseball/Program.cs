using System;
using System.Collections.Generic;
using System.Linq;
using Baseball.Classes;
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

            //to do maybe - just save the batting average
            List<BaseballPlayer> team = new List<BaseballPlayer>();
            while (team.Count < numPlayers)
            {
                team.Add(GetIndividualPlayerData());                              
            }
            foreach(BaseballPlayer player in team)
            {
                Console.WriteLine($"{player.FirstName} has a batting average of: {player.FormattedBattingAverage}");
            }


            // find the player with the batting average equal to the max batting average in team
            BaseballPlayer bestBA = team.Find(player => player.BattingAverage == team.Max(match => match.BattingAverage));
            Console.WriteLine($"Player with best average: {bestBA.FirstName} with an average of: {bestBA.FormattedBattingAverage}");

        }

        private static BaseballPlayer GetIndividualPlayerData()
        {
            BaseballPlayer newPlayer = new BaseballPlayer();

            Console.WriteLine("Enter player name: ");
            newPlayer.FirstName = Console.ReadLine();
            int numberOfHits = int.MaxValue;
            do
            {
                Console.WriteLine($"Enter number times {newPlayer.FirstName} has been at bat: ");
                newPlayer.TimesAtBat = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter number of times {newPlayer.FirstName} has hit: ");
                numberOfHits = int.Parse(Console.ReadLine());
            } while (numberOfHits > newPlayer.TimesAtBat && numberOfHits >= 0);

            newPlayer.NumHits = numberOfHits;

            return newPlayer;
        }
        
    }
}
