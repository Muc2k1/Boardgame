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
        private Dictionary<eHerb,int> playerHerbs;
        private Dictionary<eMedicinalProp, int> playerPoisons;
        private Dictionary<ElixirCardData, int> playerHand;
        public bool IsCanMakeElixir(ElixirRecipe recipe)
        {
            return true;
        }
        public void MakeAElixir(ElixirRecipe recipe)
        {

        }
    }
}
