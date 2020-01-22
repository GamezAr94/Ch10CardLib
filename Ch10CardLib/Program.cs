using System;

namespace Ch11CardLib
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deck myDeck = new Deck();
            //myDeck.Shuffle();
            //myDeck.displayDeck();
            bool isFlush = false;

            #region
            /*
            for(int i = 0; i < 52; i++)
            {
                Card tempCard = myDeck.getCard(i);
                Console.Write(tempCard.ToString());
                if (i != 51)
                    Console.Write(", ");
                else
                    Console.WriteLine();
            }
            */
            #endregion
            while (!isFlush)
            {
                Deck myDeck = new Deck();
                isFlush = false;
                myDeck.Shuffle();
                int handFlushIndex = 0;
                for(int hand = 0; hand < 10; ++hand)
                {
                    isFlush = true;
                    Suit suitCard = new Suit();
                    suitCard = myDeck.getCard(hand * 5).suit;
                    for(int card = 1; card < 5; ++card)
                    {
                        if (suitCard != myDeck.getCard(hand * 5 + card).suit)
                        {
                            isFlush = false;
                        }
                    }
                    if (isFlush)
                    {
                        handFlushIndex = hand * 5;
                        break;
                    }
                }
                if (isFlush)
                {
                    Console.WriteLine("Flush!!!");
                    for (int i = 0; i < 5; ++i)
                    {
                        Console.Write(myDeck.getCard(handFlushIndex + i) + " ");
                    }
                }
                else
                {
                    Console.WriteLine("No Flush.");
                }
                Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
