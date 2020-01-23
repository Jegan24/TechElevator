using DeckOfCards.Classes;
using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Card fiveOfSpades = new Card(5, "Spades");
            Card twoOfDiamons = new Card(2, "Diamonds");

            Card copyOffiveOfSpades = fiveOfSpades.Copy(); 

            if (fiveOfSpades.BeatsCard(twoOfDiamons))
            {
                Console.WriteLine($"{fiveOfSpades} wins");
            }
            else
            {
                Console.WriteLine($"{twoOfDiamons} wins");
            
            }

            // Let's store all of our cards in a list
            // CODE GOES HERE
            List<Card> deck = new List<Card>();

            while (true)
            {
                Console.WriteLine("What do you want to do? ");
                Console.WriteLine("1. Create a new card.");
                Console.WriteLine("2. Display all of the cards.");
                Console.WriteLine("3. Flip all of the cards.");
                Console.WriteLine("Q. Quit");

                /*
                Card x = new Card(); 
                x.Flip();  allowed since Flip is public
                x.IsFaceUp = true; //not allowed since it's private set and we aren't inside of class
                */

                string input = Console.ReadLine();

                if (input == "1")
                {
                    // Get the value for the new card
                    Console.Write("What is the value of the card (1-13): ");
                    int value = int.Parse(Console.ReadLine());

                    // Get the suit for the new card
                    Console.Write("What suit does the card have (Hearts, Diamonds, Clubs, Spades): ");
                    string suit = Console.ReadLine();

                    // Is the card face up or face down
                    Console.Write("Is the card face up (True/False): ");
                    bool isFaceUp = bool.Parse(Console.ReadLine());

                    // Create the card and add to the list
                    Card card = new Card(value, suit, isFaceUp);
                    deck.Add(card);
                    
                }
                else if (input == "2")
                {
                    Console.WriteLine("Displaying all of the cards.");

                    // Loop through each of the cards
                    foreach(Card card in deck)
                    {
                        Console.WriteLine(card);
                    }
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    
                }
                else if (input == "3")
                {
                    Console.WriteLine($"Flipping the cards.");
                    
                    // Loop through each of the cards and flip them
                    foreach(Card c in deck)
                    {
                        c.Flip(); 
                    }
                    
                }
                else if (input == "Q" || input=="q")
                {
                    break;
                }

                // Wait for user to press enter and clear screen.
               
                Console.Clear();
            }
        }
    }
}
