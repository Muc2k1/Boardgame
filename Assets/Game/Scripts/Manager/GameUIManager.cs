using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElixirMaker.Definer;
using ElixirMaker.Object;

namespace ElixirMaker.Manager
{
    public class GameUIManager : MonoBehaviour
    {
        [SerializeField] private Transform playerHand;
        [SerializeField] private CardSample cardSample;
        public void CreateCardToPlayerHand(int playerIndex, ElixirCard currentCard)
        {
            CardSample newDisplayCard = Instantiate(cardSample, this.playerHand); //playerIndex to check what hand we wanna create card
            newDisplayCard.Init(currentCard);
        }
    }
}