using System;

namespace Ch11CardLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Flush();
            Console.ReadKey();
        }
        static void Flush()
        {
            bool isFlush = false;

            while (!isFlush)
            {
                Deck myDeck = new Deck();
                isFlush = false;
                myDeck.Shuffle();
                int handFlushIndex = 0;
                for (int hand = 0; hand < 10; ++hand)
                {
                    isFlush = true;
                    Suit suitCard = new Suit();
                    suitCard = myDeck.getCard(hand * 5).suit;
                    for (int card = 1; card < 5; ++card)
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

        }
    }
}
