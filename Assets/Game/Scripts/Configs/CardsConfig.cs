using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElixirMaker.Definer;

namespace ElixirMaker.Config
{
    [CreateAssetMenu(fileName = "Card Dictionary", menuName = "Card Config/Card Dictionary")]
    public class CardsConfig : ScriptableObject
    {
        public List<ElixirCardFamilyData> CardFamilies;
        public ElixirCardData RandomPickOneCard(ePlace CardFamily)
        {
            foreach (ElixirCardFamilyData family in this.CardFamilies)
            {
                if (family.CardFamily == CardFamily)
                {
                    int randomPick = UnityEngine.Random.Range(0, family.CardList.Count);
                    return family.CardList[randomPick];
                }
            }
            Debug.LogError("[CardsConfig] Couldn't pick random card from : " + CardFamily.ToString() + " Family, return null!");
            return null;
        }
    }
    [Serializable]
    public class ElixirCardFamilyData
    {
        public ePlace CardFamily;
        public List<RecipeCardData> CardList; //will replace ElixirCardData to others
    }
    [Serializable]
    public class ElixirCardData : ScriptableObject
    {
        public eCardType TYPE;
        public string CardTitle;
        public Sprite CardArtwork;
        public string CardDescription;
        public Color CardData; //That's mean card effect, will change later
    }
    [Serializable]
    public class ElixirRecipe
    {
        public List<RecipeLine> Lines;
        public ElixirConfig Result;
        public Dictionary<eHerb,int> ConvertToDictionary()
        {
            Dictionary<eHerb,int> result = new Dictionary<eHerb, int>();
            return result;
        }
    }
    [Serializable]
    public class RecipeLine
    {
        public bool IsNotInclude;
        public eHerb HerbType;
        public int Quantity;
    }
    [Serializable]
    public class SpellCardData : ElixirCardData
    {
        public new const eCardType TYPE = eCardType.Spell;
        // public string CardTitle;
        // public Sprite CardArtwork;
        // public string CardDescription;
        // public Color CardData; //That's mean card effect, will change later
    }
    // [Serializable]
    // public class ElixirCardData
    // {
    //     public eCardType TYPE;
    //     public string CardTitle;
    //     public Sprite CardArtwork;
    //     public string CardDescription;
    //     public Color CardData; //That's mean card effect, will change later
    // }
    // [Serializable]
    // public class ElixirCardData
    // {
    //     public eCardType TYPE;
    //     public string CardTitle;
    //     public Sprite CardArtwork;
    //     public string CardDescription;
    //     public Color CardData; //That's mean card effect, will change later
    // }
}