using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElixirMaker.Definer;

namespace ElixirMaker.Config
{
    [CreateAssetMenu(fileName = "Card Dictionary", menuName = "Card Config/Card Dictionary")]
    public class ElixirConfig : ScriptableObject
    {
        public eElixirType Type;
        public string ElixirTitle;
    }
}