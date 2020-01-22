using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch11CardLib
{
    class Cards : CollectionBase
    {
        public void Add(Cards newCard)
        {
            List.Add(newCard);
        }
        public void Remove(Cards newCard)
        {
            List.Remove(newCard);
        }
        public Card this[int cardIndex]
        {
            get { return (Card)List[cardIndex]; }
            set { List[cardIndex] = value; }
        }
        public void CopyTo(Cards targetCards)
        {
            for(int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }
        public bool Contains(Card card)
        {
            return InnerList.Contains(card);
        }
    }
}
