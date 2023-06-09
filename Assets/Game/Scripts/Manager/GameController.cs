using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElixirMaker.Definer;
using ElixirMaker.Config;
using ElixirMaker.Object;

namespace ElixirMaker.Manager
{
    public class GameController : MonoBehaviour
    {
        public static GameController Instance;
        public List<PlayerData> playerDatas;
        public GameUIManager gameUIManager { get; private set; }
        public DecksManager decksManager { get; private set; }
        private void Awake() 
        {
            Instance = this;

            this.gameUIManager = GetComponent<GameUIManager>();
            this.decksManager = GetComponent<DecksManager>();
        }
        public void DrawACard(int playerIndex, ePlace place)
        {
            //player index will define later
            ElixirCardData currentCard = this.decksManager.DrawACardFrom(place);
            this.gameUIManager.CreateCardToPlayerHand(playerIndex, currentCard);
        }
        public void OnCardInspect(int playerIndex, CardSample currentCard)
        {
            this.gameUIManager.InspectCard(playerIndex, currentCard);
        }
        public void OnCardPlay(int playerIndex, CardSample card)
        {
            Destroy(card.gameObject);
        }
        public void OnPlayerMakeElixir(int playerIndex, ElixirRecipe recipe)
        {
            this.playerDatas[playerIndex].MakeAElixir(recipe);
        }
        public void OnPlayerUseSpell(int playerIndex, SpellCardData spellData)
        {

        }
    }
}
