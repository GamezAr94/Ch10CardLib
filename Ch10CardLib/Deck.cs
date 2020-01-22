using System;
using System.Collections.Generic;
using System.Text;

namespace Ch11CardLib
{
    class Deck
    {
        //Simple Array collection
        //private Card[] cards;

        private Cards cards = new Cards();//ArrayList collection

        public Deck()
        {
            //Simple Array collection
            //cards = new Card[52];

            for(int suitVals = 0; suitVals < 4; ++suitVals)
            {
                for(int rankVals = 0; rankVals < 13; ++rankVals)
                {
                    //Simple Array collection
                    //cards[suitVals * 13 + rankVals - 1] = new Card((Suit)suitVals, (Rank)rankVals);

                    cards.Add(new Card((Suit)suitVals, (Rank)rankVals));//ArrayList collection
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
            //Simple Array collection
            //Card[] newDeck = new Card[52];

            Cards newDeck = new Cards();//ArrayList collection
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for(int i = 0; i < 52; ++i)
            {
                int sourceCard = 0;

                bool foundCard = false;
                while(foundCard == false)
                {
                    sourceCard = sourceGen.Next(52);
                    if(assigned[sourceCard] == false)
                    {
                        foundCard = true;
                    }
                }
                assigned[sourceCard] = true;
                //Simple Array collection
                //newDeck[sourceCard] = cards[i];

                newDeck.Add(cards[sourceCard]);//ArrayList collection
            }
            //Simple Array collection
            //newDeck.CopyTo(cards, 0);

            //ArrayList collection
            newDeck.CopyTo(cards);
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
