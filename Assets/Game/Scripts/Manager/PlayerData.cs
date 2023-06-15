using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElixirMaker.Definer;
using ElixirMaker.Config;

namespace ElixirMaker.Manager
{
    public class PlayerData
    {
        private string playerAlias;
        private Dictionary<eHerb,int> playerHerbs = new Dictionary<eHerb,int>();
        private Dictionary<eMedicinalProp, int> playerPoisons = new Dictionary<eMedicinalProp, int>();
        private Dictionary<ElixirCardData, int> playerHand = new Dictionary<ElixirCardData, int>();
        public bool IsCanMakeElixir(RecipeCardData cardData)
        {
            Dictionary<eHerb,int> recipeRequire = cardData.Recipe.ConvertToDictionary();
            foreach(KeyValuePair<eHerb,int> line in recipeRequire)
            {
                if (this.playerHerbs.ContainsKey(line.Key) == false)
                {
                    Debug.Log("[PlayerData/IsCanMakeElixir] Player don't have : " + line.Key);
                    return false;
                }
                else if (this.playerHerbs[line.Key] < line.Value)
                {
                    Debug.Log("[PlayerData/IsCanMakeElixir] Player don't have enough : " + line.Key + " " + playerHerbs[line.Key] + " / " + line.Value);
                    return false;
                }
            }
            return true;
        }
        public void MakeAPoison(RecipeCardData cardData)
        {
            Dictionary<eHerb,int> recipeRequire = cardData.Recipe.ConvertToDictionary();
            if (IsCanMakeElixir(cardData) == false)
            {
                Debug.LogError("[PlayerData/MakeAPoison] Player can't make : " + cardData.CardTitle);
                return;
            }
            foreach(KeyValuePair<eHerb,int> line in recipeRequire)
            {
                this.playerHerbs[line.Key] -= line.Value;
            }
            AddPoison(cardData.MedicinalProp);
        }
        private void AddPoison(eMedicinalProp medicinalProp)
        {
            if (this.playerPoisons.ContainsKey(medicinalProp) == false)
            {
                this.playerPoisons.Add(medicinalProp, 1);
            }
            else
                this.playerPoisons[medicinalProp] += 1;
        }
    }
}
