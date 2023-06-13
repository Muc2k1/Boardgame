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
        public ElixirCardData CardData { get; private set; }
        public void Init(ElixirCardData cardData)
        {
            this.CardData = cardData;

            this.cardTitleTxt.text = this.CardData.CardTitle;
            this.cardArtwork.sprite = this.CardData.CardArtwork;
            cardBackground.color = this.CardData.CardData; //Dummy code
        }
        public void OnInspect()
        {
            GameController.Instance.OnCardInspect(0, this);
        }
        public void PlayThisCard()
        {
            switch (this.CardData.TYPE)
            {
                case eCardType.Recipe:
                    RecipeCardData recipeCardData = (RecipeCardData)this.CardData;
                    GameController.Instance.OnPlayerMakeElixir(0, recipeCardData.Recipe);
                    //Create the elixir
                    break;
                case eCardType.Spell:
                    SpellCardData spellData = (SpellCardData)this.CardData;
                    GameController.Instance.OnPlayerUseSpell(0, spellData);
                    //Use the speed
                    break;
            }
        }
    }
}
