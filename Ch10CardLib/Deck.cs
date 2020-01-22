using System;
using System.Collections.Generic;
using System.Text;

namespace Ch11CardLib
{
    class Deck
    {
        private Card[] cards;

        public Deck()
        {
            cards = new Card[52];
            for(int suitVals = 0; suitVals < 4; ++suitVals)
            {
                for(int rankVals = 1; rankVals < 14; ++rankVals)
                {
                    cards[suitVals * 13 + rankVals - 1] = new Card((Suit)suitVals, (Rank)rankVals);
                }
            }
        }

        public Card getCard(int cardNum)
        {
            if(cardNum >= 0 && cardNum <= 51)
            {
                return cards[cardNum];
            }
            else
            {
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and 51"));
            }
            return cards[cardNum];
        }

        public void Shuffle()
        {
            Card[] newDeck = new Card[52];
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for(int i = 0; i < 52; ++i)
            {
                int destCard = 0;
                bool foundCard = false;
                while(foundCard == false)
                {
                    destCard = sourceGen.Next(52);
                    if(assigned[destCard] == false)
                    {
                        foundCard = true;
                    }
                }
                assigned[destCard] = true;
                newDeck[destCard] = cards[i];
            }
            newDeck.CopyTo(cards, 0);
        }

        public void displayDeck()
        {
            for(int i = 0; i < 52; ++i)
            {
                Console.Write(cards[i].ToString());
                if (i != 51)
                    Console.Write(", ");
                else
                    Console.WriteLine();
            }
        }
    }
}
