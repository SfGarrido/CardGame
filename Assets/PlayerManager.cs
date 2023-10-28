using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager: MonoBehaviour
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
        public int cardsLeft = 0;
        public Deck()
        {

        }
        public Card Draw()
        {
            return myCards[0];
        }
        public void Shuffle()
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

        public void Rearrange()
        {

        }

        public void Playcard(int num)
        {
            myCards[num].effect();
        }
        public void AddCard(Card newCard)
        {
            myCards[-1] = newCard;
        }
    }
    public class Field
    {
        public Card[] Monsters;
        public Card[] Spells;
        public Field(){}
    }
    public class Player { 
        public Deck myDeck;
        public DiscardPile myPyle;
        public Hand myHand;
        public Field myField;
        public Player() { }
        public void Draw(int x)
        {
            for (int i = 0; i < x; i++)
            {
                if (myDeck.cardsLeft > 0)
                {
                    myHand.AddCard(myDeck.Draw());
                }
                else
                {
                    return; // Implement lose
                }
            }
        }

    }
}
