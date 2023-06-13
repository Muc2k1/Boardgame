using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ElixirMaker.Definer;
using ElixirMaker.Config;
using ElixirMaker.Manager;

namespace ElixirMaker.Manager
{
    public class GameConfig : MonoBehaviour
    {
        [SerializeField] private HerbDictionary herbDictionary;
        public Sprite GetHerbSprite(eHerb herb)
        {
            HerbConfig currentHerb = this.herbDictionary.GetHerbConfig(herb);
            if (currentHerb != null)
                return currentHerb.MainSprite;
            Debug.LogError("[GameConfig/GetHerbSprite] can't get herb sprite with type " + herb + ". Return null.");
            return null;
        }
    }
}