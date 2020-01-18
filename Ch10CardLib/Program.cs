using System;

namespace Ch10CardLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            myDeck.displayDeck();

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

            Console.ReadKey();
        }
    }
}
