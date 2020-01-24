using DeckOfCards.Classes;
using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Card c = new Card(); forbidden


            Deck deck = new Deck();
            deck.Shuffle();
            deck.Shuffle(5);

            List<Card> katiesHand = new List<Card>();
            List<Card> irvingHand = new List<Card>();

            for (int i = 0; i < 5; i++)
            {
                katiesHand.Add(deck.DealOne());
                irvingHand.Add(deck.DealOne());
            }
            Console.WriteLine("Katies Hand");
            foreach(Card c in katiesHand)
            {
                Console.Write(c+" "); 
            }
        }
    }
}
