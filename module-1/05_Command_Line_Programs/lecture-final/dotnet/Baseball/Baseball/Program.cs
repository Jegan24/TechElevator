using System;

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
            string[] playerNames = new string[numPlayers];
            int[] timesAtBat = new int[numPlayers];
            int[] numHits = new int[numPlayers];
            GetPlayerData(numPlayers, playerNames, timesAtBat, numHits);
            for (int i = 0; i < numPlayers; i++)
            {
                Console.WriteLine(playerNames[i] + " " + FormatBattingAverage(numHits[i], timesAtBat[i]));
            }
            Console.WriteLine("Player with best average: "+FindBestBattingAverage( playerNames, timesAtBat, numHits));

            //for fun let's test the string.split
            string[] ar = "this|is|a test".Split("|");
            for(int i=0; i < ar.Length; i++)
            {
                Console.WriteLine("at index " + i + " " + ar[i]);
            }
        }

        private static string FindBestBattingAverage( string[] playerNames, int[] timesAtBat, int[] numHits)
        {
            string playerNameWithBestAverage = "nobody";
            double bestAverage = 0;
            for (int i = 0; i < numHits.Length; i++)
            {
                if ((double)numHits[i] / timesAtBat[i] > bestAverage)
                {
                    playerNameWithBestAverage = playerNames[i];
                    bestAverage = (double)numHits[i] / timesAtBat[i];
                }

            }
            return playerNameWithBestAverage;
        }

        private static void GetPlayerData(int numPlayers, string[] playerNames, int[] timesAtBat, int[] numHits)
        {
            for (int i = 0; i < numPlayers; i++)
            {
                Console.WriteLine("Enter player name: ");
                playerNames[i] = Console.ReadLine();
                int numberOfHits = 0;
               do
                {
                    Console.WriteLine("Times at bat must be less than number of hits.");

                    Console.WriteLine("Enter times " + playerNames[i] + " has been at bat: ");
                    string strTimesAtBat = Console.ReadLine();
                    timesAtBat[i] = int.Parse(strTimesAtBat);
                    numberOfHits = timesAtBat[i] + 1;

                    Console.WriteLine("Enter number of hits: ");
                    string strNumHits = Console.ReadLine();                 
                    numberOfHits = int.Parse(strNumHits);              
                    
                }
                while   (numberOfHits > timesAtBat[i]) ;
                
                numHits[i] = numberOfHits;
            }
        }

        public static string FormatBattingAverage(int numHits, int timesAtBat)
        {
            
            double battingAverage = (double) numHits / timesAtBat;
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
}
