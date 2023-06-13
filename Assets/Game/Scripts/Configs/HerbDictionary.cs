using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ElixirMaker.Definer;
namespace ElixirMaker.Config
{
    [CreateAssetMenu(fileName = "Herb Dictionary", menuName = "Herb Dictionary")]
    public class HerbDictionary : ScriptableObject
    {
        public List<HerbConfig> herbConfigs;
        public HerbConfig GetHerbConfig(eHerb type)
        {
            foreach(HerbConfig herbConfig in this.herbConfigs)
            {
                if (herbConfig.HerbType == type)
                    return herbConfig;
            }
            Debug.LogError("[HerbDictionary/GetHerbConfig] We don't have " + type + " in dictionary!!! Return null.");
            return null;
        }
    }
    [Serializable]
    public class HerbConfig
    {
        public eHerb HerbType;
        public Sprite MainSprite;
    }
}