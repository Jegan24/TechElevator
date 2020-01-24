using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Classes
{
    class Deck
    {
        private List<Card> Cards { get; set; } = new List<Card>(); 

        public Deck()
        {
            PopulateCards();
        }

        private void PopulateCards()
        {
            string[] suits = { "spades", "hearts", "clubs", "diamonds" };
            foreach (string suit in suits)
            {
                for (int i = 1; i <= 13; i++)
                {
                    Card c = new Card(suit, i);
                    Cards.Add(c);
                }
            }
        }

        public void Shuffle()
        {
            bridgeShuffle(10);
        }
        public void Shuffle(int numberOfTimes)
        {
            bridgeShuffle(numberOfTimes);
        }
        //shuffle

        private void bridgeShuffle(int numberOfTimes)
        {
            for (int times = 0; times < numberOfTimes; times++)
            {
                //split the deck into two smaller lists
                //loop until both lists are empty
                //   take random 1-5 number cards from top half
                //   take random 1-5 number cards from bottom half

                List<Card> topHalf = Cards.GetRange(0, 26);
                Cards.RemoveRange(0, 26);

                List<Card> bottomHalf = Cards.GetRange(0, 26);
                Cards.RemoveRange(0, 26);

                Random random = new Random();

                while (topHalf.Count > 0 || bottomHalf.Count > 0)
                {
                    int takeFromTop = random.Next(1, 5);
                    for (int i = 0; i < takeFromTop && i < topHalf.Count; i++)
                    {
                        Card result = topHalf[0];
                        topHalf.Remove(result);
                        Cards.Add(result);
                    }
                    int takeFromBottom = random.Next(1, 5);
                    for (int i = 0; i < takeFromBottom && i < bottomHalf.Count; i++)
                    {
                        Card result = bottomHalf[0];
                        bottomHalf.Remove(result);
                        Cards.Add(result);
                    }
                }
            }
        }

        //deal a card
        public Card DealOne()
        {
            Card result =null ;

            if (Cards.Count == 0)
            {
                PopulateCards();
            }
                        
            result = Cards[0];
            Cards.Remove(result);
            
            return result;
        }
    }
}
