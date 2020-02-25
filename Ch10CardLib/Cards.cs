using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch11CardLib
{
    class Cards : CollectionBase
    {
        public void Add(Card newCard)
        {
            List.Add(newCard);
        }
        public void Remove(Card oldCard)
        {
            List.Remove(oldCard);
        }
        public Card this[int cardIndex]
        {
            get => (Card)List[cardIndex];
            set => List[cardIndex] = value;
        }
        public void CopyTo(Cards targetCards)
        {
            for (int i = 0; i < this.Count; i++)
            {
                targetCards[i] = this[i];
            }
        }
        public bool Contains(Card card) => InnerList.Contains(card);
    }
}
