using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    public abstract class Card
    {
        public string name;
        public string description;
        public Sprite icon;
        public int costFood;
        public int costMana;
        
        public Card()
        {

        }

        public abstract void effect();
    }
    public class Deck
    {
        //Top of the deck is at index 0. 
        public Card[] myCards;

        public Deck()
        {

        }
        public Card draw()
        {
            return myCards[0];
        }
        public void shuffle()
        {

        }
    }
    public class DiscardPile
    {
        public Card[] myCards;
        public DiscardPile()
        {

        }
    }

    public class Hand
    {
        public Card[] myCards;
        public Hand()
        {

        }

        public void rearrange()
        {

        }

        public void playcard(int num)
        {
            myCards[num].effect();
        }
    }
}
