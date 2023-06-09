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
        // This can hold in player hand
        Recipe = 0, 
        Herb,

        // This must use immediately when player draw this card
        Immediately,
        Spell, // Same with Potion/Elixir
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