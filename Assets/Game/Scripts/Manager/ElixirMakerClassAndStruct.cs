using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ElixirMaker.Object;

namespace ElixirMaker.Definer
{
    public class ElixirCard
    {
        public string Title;
        public Color CardData; //Will change to card data later
        public ElixirCard()
        {
            this.Title = "Sample Card";

            float randomr = UnityEngine.Random.Range(0f, 1f); //Dummy
            float randomg = UnityEngine.Random.Range(0f, 1f); //Dummy
            float randomb = UnityEngine.Random.Range(0f, 1f); //Dummy
            this.CardData = new Color(randomr, randomg, randomb, 1f); //Dummy
        }
    }
    public class ElixirEvents
    {
    
    }
}
