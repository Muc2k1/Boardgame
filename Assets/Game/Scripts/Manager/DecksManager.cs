using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElixirMaker.Definer;
using ElixirMaker.Config;

namespace ElixirMaker.Manager
{
    public class DecksManager : MonoBehaviour
    {
        [SerializeField] private CardsConfig cardsConfig;
        public ElixirCardData DrawACardFrom(ePlace place)
        {
            ElixirCardData cardData = this.cardsConfig.RandomPickOneCard(place);
            return cardData;
        }
    }
}
