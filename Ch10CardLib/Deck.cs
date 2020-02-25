using System;
using System.Collections.Generic;
using System.Text;

namespace Ch11CardLib
{
    class Deck
    {
        private Cards cards = new Cards();

        public Deck()
        {
            for (int suitVals = 0; suitVals < 4; ++suitVals)
            {
                for (int rankVals = 1; rankVals < 14; ++rankVals)
                {
                    cards.Add(new Card((Suit)suitVals, (Rank)rankVals));
                }
            }
        }

        public Card getCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
            {
                return cards[cardNum];
            }
            else
            {
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and 51"));
            }
        }

        public void Shuffle()
        {
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for (int i = 0; i < 52; ++i)
            {
                int sourceCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    sourceCard = sourceGen.Next(52);
                    if (assigned[sourceCard] == false)
                    {
                        foundCard = true;
                    }
                }
                assigned[sourceCard] = true;
                newDeck.Add(cards[sourceCard]);
            }
            newDeck.CopyTo(cards);
        }

        public void displayDeck()
        {
            for (int i = 0; i < 52; ++i)
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
