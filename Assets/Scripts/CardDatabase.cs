using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();


    void Awake()
    {
        cardList.Add(new Card(0,"Wraith",0,0,0,0,"How did you get this?"));
        cardList.Add(new Card(1,"Wild Boar",1,0,1,2,"Blank"));
        cardList.Add(new Card(2,"Fire Spirit",2,0,3,3,"Blank"));
        cardList.Add(new Card(3,"Boulderfist Ogre",6,0,6,7,"Legend amongst ogres."));
    }
}
