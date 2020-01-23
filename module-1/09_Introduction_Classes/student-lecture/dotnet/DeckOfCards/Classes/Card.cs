using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace DeckOfCards.Classes
{
    class Card
    {
        /// <summary>
        /// clubs, spades, hearts, diamonds
        /// </summary>
        public string Suit { get; }
        /// <summary>
        /// jack => 11, queen => 12, king => 13, ace => 1
        /// </summary>
        public int Value { get; }
        public bool IsFaceUp { get; private set; }


        public Card(string suit, int value, bool isFaceUp)
        {
            TextInfo ti = new CultureInfo("en-US", false).TextInfo;
            this.Suit = ti.ToTitleCase(suit);
            this.Value = value;
            this.IsFaceUp = isFaceUp;
        }

        public override string ToString()
        {
            string name;
            string output;
            if (IsFaceUp)
            {
                switch (this.Value)
                {
                    case 1:
                        name = "Ace";
                        break;
                    case 11:
                        name = "Jack";
                        break;
                    case 12:
                        name = "Queen";
                        break;
                    case 13:
                        name = "King";
                        break;
                    default:
                        name = this.Value.ToString();
                        break;
                }
                output = $"{name} of {Suit}";
            }
            else
            {
                output = "Back of Card";
            }
            
            return output;
        }

        public void Flip()
        {
            IsFaceUp = !IsFaceUp;
        }

    }
}
