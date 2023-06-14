using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElixirMaker.Definer;
using ElixirMaker.Config;

namespace ElixirMaker.Object
{
    public class RecipeDisplay : MonoBehaviour
    {
        [SerializeField] private GameObject recipeElementSample;
        private List<RecipeElement> recipeElements;
        public void CheckIsRecipeCardType(CardSample card)
        {
            if (card.CardData.TYPE == eCardType.Recipe)
            {
                RecipeCardData data = (RecipeCardData)card.CardData;
                ShowCardRecipe(data.Recipe);
            }
        }
        private void ShowCardRecipe(ElixirRecipe recipe)
        {
            RemoveAllChildren();
            foreach (RecipeLine line in recipe.Lines)
            {
                GameObject newRecipeElement = Instantiate(this.recipeElementSample, this.transform);
                RecipeElement newRecipeElementComp = newRecipeElement.GetComponent<RecipeElement>();
                newRecipeElementComp.Init(line.HerbType, line.Quantity);
            }
        }
        private void RemoveAllChildren()
        {
            for (int i = this.transform.childCount - 1; i >= 0; i--)
            {
                Destroy(this.transform.GetChild(i).gameObject);
            }
        }
    }
}