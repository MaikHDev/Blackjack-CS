using System;

namespace Blackjacktutorial
{
    internal class Card
    {
        public enum Suit
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }

        public enum Rank
        {
            Ace = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }

        public Suit typeSuit { get; set; }
        public Rank typeRank { get; set; }

        public Card(Rank rank, Suit suit)
        {
            typeRank = rank;
            typeSuit = suit;
        }

        public override string ToString()
        {
            return $" {typeRank} of {typeSuit}  ";
        }

    }
}

