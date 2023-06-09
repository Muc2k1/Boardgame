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
            GameController.Instance.OnCardInspect(0, this);
        }
        public void PlayThisCard()
        {
            switch (this.cardData.TYPE)
            {
                case eCardType.Recipe:
                    RecipeCardData recipeCardData = (RecipeCardData)this.cardData;
                    GameController.Instance.OnPlayerMakeElixir(0, recipeCardData.Recipe);
                    //Create the elixir
                break;
                case eCardType.Spell:
                    SpellCardData spellData = (SpellCardData)this.cardData;
                    GameController.Instance.OnPlayerUseSpell(0, spellData);
                    //Use the speed
                break;
            }
        }
    }
}
