using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using ElixirMaker.Definer;
using ElixirMaker.Manager;

namespace ElixirMaker.Object
{
    public class CardSample : MonoBehaviour
    {
        [SerializeField] private TMP_Text cardTitleTxt;
        [SerializeField] private Image cardBackground; //Dummy
        private ElixirCard cardData;
        public void Init(ElixirCard cardData)
        {
            this.cardData = cardData;

            this.cardTitleTxt.text = this.cardData.Title;
            cardBackground.color = this.cardData.CardData; //Dummy code
        }
        public void OnInspect()
        {
            GameController.Instance.OnCardPlay(0, this);
        }
    }
}
