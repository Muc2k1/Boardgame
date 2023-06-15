using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElixirMaker.Definer;

namespace ElixirMaker.Config
{
    [CreateAssetMenu(fileName = "Card Recipe", menuName = "Card Config/Card Recipe")]
    public class RecipeCardData : ElixirCardData
    {
        public new const eCardType TYPE = eCardType.Recipe;
        public eMedicinalProp MedicinalProp;
        public ElixirRecipe Recipe;
    }
}