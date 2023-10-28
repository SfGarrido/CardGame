using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardDisplay : MonoBehaviour
{
    public Card2 card;
    public Text nameText;
    public Text costManaText;
    public Text costFoodText;
    public Text attackText;
    public Text healthText;
    public Text descText;

    void Start()
    {
        nameText.text = card.cardName;
        descText.text = card.cardDescription;
        costManaText.text = card.costMana.ToString();
        costFoodText.text = card.costFood.ToString();
        attackText.text = card.attack.ToString();
        healthText.text = card.health.ToString();
    }
}
