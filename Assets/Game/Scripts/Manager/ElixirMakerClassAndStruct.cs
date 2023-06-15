using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ElixirMaker.Object;
using ElixirMaker.Config;

namespace ElixirMaker.Definer
{
    public class InspectButtonShowState
    {
        public static InspectButtonShowState RECIPE_CARD_STATE = new InspectButtonShowState(false, false, true);
        public static InspectButtonShowState TEMP_CARD_STATE = new InspectButtonShowState(false, false, false);
        public bool IsShowTrade;
        public bool IsShowUse;
        public bool IsShowCreate;
        public InspectButtonShowState() {}
        public InspectButtonShowState(bool isShowTrade, bool isShowUse, bool isShowCreate) 
        {
            this.IsShowTrade = isShowTrade;
            this.IsShowUse = isShowUse;
            this.IsShowCreate = isShowCreate;
        }
    }
}
