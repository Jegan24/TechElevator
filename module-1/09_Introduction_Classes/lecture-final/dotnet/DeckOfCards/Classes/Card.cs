using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Classes
{
    class Card
    {
        /// <summary>
        /// This is going to be the suit - it'll be hearts, clubs, spades, diamonds all in lowercase
        /// </summary>
        public string Suit { get; }

        public Card Copy()
        {
            Card theNewOne = new Card(Value, Suit, IsFaceUp);
            return theNewOne; 
        }

        /// <summary>
        /// store jack as 11, queen as 12, king as 13 aces are 1
        /// </summary>
        public int Value { get; }

        public bool IsFaceUp { get; private set; }

        public void Flip()
        {
            // IsFaceUp = !IsFaceUp;
            if (IsFaceUp) //if its face up flip it over
                IsFaceUp = false;
            else 
                IsFaceUp = true;
        }


        public Card(int value, string suit)
        {
            //value = Value; not this
            Value = value;
            Suit = suit;
            IsFaceUp = false; //this is the default, adding this line improves readability and maintainability
        }

        public Card(int value, string suit,bool isFaceUp)
        {
            //value = Value; not this
            Value = value;
            Suit = suit;
            IsFaceUp = isFaceUp;
        }

        public bool BeatsCard(Card otherOne)
        {
            if (Value > otherOne.Value)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            if(IsFaceUp)
            {
                string strVal = Value.ToString();
                if (Value==11)
                {
                    strVal = "Jack";
                }
                else if (Value == 12)
                {
                    strVal = "Queen";
                }
                else if (Value == 13)
                {
                    strVal = "King";
                }
                else if (Value == 1)
                {
                    strVal = "Ace";
                }
                return strVal + " of " + Suit;
            }
            else
            {
                return "back of card";
            }
        }

    }
}
