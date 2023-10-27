using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
    public int id;
    public string cardName;
    public int costFood;
    public int costMana;
    public int health;
    public int attack;
    public string cardDescription;


    public Card()
    {


    }


    public Card(int Id, string CardName, int CostFood, int CostMana,int Attack, int Health, string CardDescription)
    {
        id = Id;
        costFood = CostFood;
        costMana = CostMana;
        attack = Attack;
        health = Health;
        cardName = CardName;
        cardDescription = CardDescription;
    }
}
