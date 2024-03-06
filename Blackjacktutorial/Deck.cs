using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjacktutorial
{
    internal class Deck
    {
        private List<Card> cards = new List<Card>();
        public Deck() {
           

            foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
            {
                foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
                {
                    Card card = new Card(rank, suit);
                    cards.Add(card);
                }
              
            }
           
        }

        public override string ToString()
        {
            String result = "";

            foreach (Card card in cards) 
            { 
                result += card.ToString();
                result += "\n";
            }

            return result;
        }
    }
}
