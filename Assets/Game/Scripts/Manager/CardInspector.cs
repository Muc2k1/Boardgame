using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElixirMaker.Config;
using ElixirMaker.Object;

namespace ElixirMaker.Manager
{
    public class CardInspector : MonoBehaviour
    {
        public void ShowCardInformation(CardSample card)
        {

        }
        public void CloseCardInspector()
        {
            this.gameObject.SetActive(false);
        }
    }
}