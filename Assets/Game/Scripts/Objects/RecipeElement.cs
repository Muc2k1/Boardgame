using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ElixirMaker.Definer;
using ElixirMaker.Manager;

namespace ElixirMaker.Object
{
    public class RecipeElement : MonoBehaviour
    {
        [SerializeField] private Image ingredientIconImg;
        [SerializeField] private TMP_Text ingredientQuantityTxt;
        public void Init(eHerb herb, int quantity)
        {
            this.ingredientIconImg.sprite = GameController.Instance.GameConfig.GetHerbSprite(herb);
            this.ingredientQuantityTxt.text = quantity.ToString();
        }
    }
}