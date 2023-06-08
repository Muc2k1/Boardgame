using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ElixirMaker.Object;
using ElixirMaker.Config;

namespace ElixirMaker.Definer
{
    public class ElixirCard //Will remove later
    {
        public string Title;
        public Sprite Artwork;
        public string Description;
        public Color CardData; //Will change to card data later
        public ElixirCard()
        {
            this.Title = "Sample Card";

            float randomr = UnityEngine.Random.Range(0f, 1f); //Dummy
            float randomg = UnityEngine.Random.Range(0f, 1f); //Dummy
            float randomb = UnityEngine.Random.Range(0f, 1f); //Dummy
            this.CardData = new Color(randomr, randomg, randomb, 1f); //Dummy
        }
        public ElixirCard(ElixirCardData cardData)
        {
            this.Title = cardData.CardTitle;
            this.Artwork = cardData.CardArtwork;
            this.Description = cardData.CardDescription;
            this.CardData = cardData.CardData; //Dummy
        }
    }
    public class ElixirEvents
    {
    
    }
}
