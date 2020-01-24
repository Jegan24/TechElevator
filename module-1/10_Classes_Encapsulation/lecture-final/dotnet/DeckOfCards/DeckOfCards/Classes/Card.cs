using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Classes
{
    class Card
    {
        public string Suit { get; }

        /// <summary>
        /// This will be 1 for ace up to 13 for king
        /// </summary>
        public int Value { get;  }

        public string FaceValue
        {
            get
            {
                return faceValues[Value];
            }
        }

        public bool IsFaceUp { get; private set; }
        
        public bool IsBlack
        {
            get
            {
                return (Suit == "clubs" || Suit == "spades");
            }
        }

        
        public Card(string suit, int value)
        {
            Suit = suit.ToLower();
            Value = value;
            IsFaceUp = false;
        }

        public Card(string suit, int value, bool isFaceUp)
        {
            Suit = suit.ToLower();
            Value = value;
            IsFaceUp = isFaceUp;
        }

        public void Flip()
        {
            IsFaceUp = !IsFaceUp;
        }

        public override string ToString()
        {
            return faceValues[Value] +" of "+ Suit; //suitSymbols[Suit];
        }
        
        private static Dictionary<string,char> suitSymbols = new Dictionary<string, char>()
        {
            //to do - make this work on the console
            {"spades", '\u2660'},
            {"diamonds", '\u2666'},
            {"clubs", '\u2663'},
            {"hearts", '\u2665'}
        };


        private static Dictionary<int,string> faceValues = new Dictionary<int, string>()
                  {
                    {1, "Ace" },
                    {2, "Two" },
                    {3, "Three" },
                    {4, "Four" },
                    {5, "Five" },
                    {6, "Six" },
                    {7, "Seven" },
                    {8, "Eight" },
                    {9, "Nine" },
                    {10, "Ten" },
                    {11, "Jack" },
                    {12, "Queen" },
                    {13, "King" }
                };
    }
}
