using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card2 : ScriptableObject
{
    public string cardName;
    public int costFood;
    public int costMana;
    public int health;
    public int attack;
    public string cardDescription;

    public void Print()
    {
        Debug.Log(cardName + ": " + cardDescription + "The card costs: " + costMana + " mana and:" + costFood + " food. It has :" + attack + "attack and: " + health + " health.");
    }

}
