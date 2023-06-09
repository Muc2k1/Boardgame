using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ElixirMaker.Definer
{
    public enum ePlace
    {
        Default = -1,
        Imperial = 0,
        HugeRoad,
        ElixirCity,
        Forest,
        Mountain,
        Ocean,
        ForgotenTown,
        DeathField
    }
    public enum eCardType
    {
        Recipe = 0,
        Immediately,
        Spell, // Same with Potion/Elixir
        Herb
    }  
    public enum eHerb
    {
        //Basic
        Red1, Red2, Red3,
        Blue1, Blue2, Blue3,
        Yellow1, Yellow2, Yellow3,
        Green,

        //Special
        Lvl1, Lvl2, Lvl3,
        AllRed, AllBlue, AllYellow,
        UnderLvl3,
        UpperLvl1,

        //
        All
    }
    public enum eElixirType
    {
        Poison,
        Spell,
        Recover,
        God
    }
    public enum eMedicinalProp
    {
        Normal,
        Dangerous,
        Deathly
    }
}