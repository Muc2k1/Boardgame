using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElixirMaker.Definer;
using ElixirMaker.Config;

namespace ElixirMaker.Object
{
    public class RecipeDisplay : MonoBehaviour
    {
        private List<RecipeElement> recipeElements;
        public void CheckIsRecipeCardType(CardSample card)
        {
            if (card.CardData.TYPE == eCardType.Recipe)
            {
                ShowCardRecipe((RecipeCardData)card.CardData);
            }
        }
        private void ShowCardRecipe(RecipeCardData recipeData)
        {

        }
    }
}