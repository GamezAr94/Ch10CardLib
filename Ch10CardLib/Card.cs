using System;
using System.Collections.Generic;
using System.Text;

namespace Ch10CardLib
{
    class Card
    {
        public readonly Suit suit;
        public readonly Rank rank;

        private Card()
        {

        }

        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public override string ToString()
        {
            return $"The {rank} of {suit}s";
        }
    }
}
