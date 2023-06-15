using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using ElixirMaker.Definer;
using ElixirMaker.Object;
using ElixirMaker.Config;

namespace ElixirMaker.Manager
{
    public class CardInspector : MonoBehaviour
    {
        [SerializeField] private TMP_Text cardTitleTxt;
        [SerializeField] private Image cardArtwork;
        [SerializeField] private Image cardBackground; //Dummy
        [SerializeField] private TMP_Text cardDescription;
        [SerializeField] private RecipeDisplay recipeDisplayer;
        [SerializeField] private GameObject backButton;
        [SerializeField] private GameObject tradeButton;
        [SerializeField] private GameObject useButton; //We separate use button and create 
        [SerializeField] private GameObject createButton;
        private ElixirCardData cardData; //Dummy
        public void Init(ElixirCardData cardData)
        {
            this.cardData = cardData;

            this.cardTitleTxt.text = this.cardData.CardTitle;
            this.cardArtwork.sprite = this.cardData.CardArtwork;
            cardBackground.color = this.cardData.CardData; //Dummy code

            switch (cardData.TYPE)
            {
                case eCardType.Recipe:
                    ShowButtons(InspectButtonShowState.RECIPE_CARD_STATE);
                break;
                case eCardType.Herb:
                    ShowButtons(InspectButtonShowState.TEMP_CARD_STATE);
                break;
                case eCardType.Immediately:
                    ShowButtons(InspectButtonShowState.TEMP_CARD_STATE);
                break;
                case eCardType.Spell:
                    ShowButtons(InspectButtonShowState.TEMP_CARD_STATE);
                break;
            }
        }
        public void ShowButtons(InspectButtonShowState cardShowState)
        {
            this.tradeButton.SetActive(cardShowState.IsShowTrade);
            this.useButton.SetActive(cardShowState.IsShowUse);
            this.createButton.SetActive(cardShowState.IsShowCreate);
        }
        public void ShowCardInformation(CardSample card)
        {
            this.recipeDisplayer.CheckIsRecipeCardType(card);
            Init(card.CardData);
        }
        public void CloseCardInspector()
        {
            this.gameObject.SetActive(false);
        }
    }
}