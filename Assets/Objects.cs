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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
