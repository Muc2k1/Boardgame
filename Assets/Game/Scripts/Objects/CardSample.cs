using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using ElixirMaker.Definer;
using ElixirMaker.Manager;
using ElixirMaker.Config;

namespace ElixirMaker.Object
{
    public class CardSample : MonoBehaviour
    {
        [SerializeField] private TMP_Text cardTitleTxt;
        [SerializeField] private Image cardArtwork;
        [SerializeField] private Image cardBackground; //Dummy
        private ElixirCardData cardData;
        public void Init(ElixirCardData cardData)
        {
            this.cardData = cardData;

            this.cardTitleTxt.text = this.cardData.CardTitle;
            this.cardArtwork.sprite = this.cardData.CardArtwork;
            cardBackground.color = this.cardData.CardData; //Dummy code
        }
        public void OnInspect()
        {
            GameController.Instance.OnCardPlay(0, this);
        }
    }
}
