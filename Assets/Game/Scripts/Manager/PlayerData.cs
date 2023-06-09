using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElixirMaker.Config;

namespace ElixirMaker.Manager
{
    public class PlayerData
    {
        public string PlayerAlias;
        public bool IsCanMakeElixir(ElixirRecipe recipe)
        {
            return true;
        }
        public void MakeAElixir(ElixirRecipe recipe)
        {

        }
    }
}
