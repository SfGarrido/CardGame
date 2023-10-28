using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId;

    public int id;
    public string cardName;
    public int costFood;
    public int costMana;
    public int attack;
    public int health;
    public string cardDescription;

    public Text nameText;
    public Text costManaText;
    public Text costFoodText;
    public Text attackText;
    public Text healthText;
    public Text descText;

    void Start()
    {
        displayCard[0] = CardDatabase.cardList[displayId];
    }

    // Update is called once per frame
    void Update()
    {
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        costFood = displayCard[0].costFood;
        costMana = displayCard[0].costMana;
        attack = displayCard[0].attack;
        health = displayCard[0].health;
        cardDescription = displayCard[0].cardDescription;

        nameText.text = "" + cardName;
        costManaText.text = "" + costMana;
        costFoodText.text = "" + costFood;
        attackText.text = "" + attack;
        healthText.text = "" + health;
        descText.text = "" + cardDescription;
    }
}