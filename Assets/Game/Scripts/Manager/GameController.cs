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
        public List<PlayerData> PlayerDatas { get; private set; }
        public GameConfig GameConfig { get; private set; }
        public GameUIManager GameUIManager { get; private set; }
        public DecksManager DecksManager { get; private set; }
        public CardSample currentInspectCard;
        private void Awake() 
        {
            Instance = this;

            this.GameUIManager = GetComponent<GameUIManager>();
            this.DecksManager = GetComponent<DecksManager>();
            this.GameConfig = GetComponent<GameConfig>();

            this.PlayerDatas = new List<PlayerData>();
            //Dummy
            this.PlayerDatas.Add(new PlayerData());
        }
        public void DrawACard(int playerIndex, ePlace place)
        {
            //player index will define later
            ElixirCardData currentCard = this.DecksManager.DrawACardFrom(place);
            this.GameUIManager.CreateCardToPlayerHand(playerIndex, currentCard);
        }
        public void OnCardInspect(int playerIndex, CardSample currentCard)
        {
            this.GameUIManager.InspectCard(playerIndex, currentCard);
            this.currentInspectCard = currentCard;
        }
        public void OnButtonCreateClicked()
        {
            this.currentInspectCard.PlayThisCard(); // will separate Use - Create
        }
        public void OnButtonUseClicked()
        {
            this.currentInspectCard.PlayThisCard(); // will separate Use - Create
        }
        public void OnCardPlay(int playerIndex, CardSample card)
        {
            Destroy(card.gameObject);
        }
        public void OnPlayerMakeElixir(int playerIndex, RecipeCardData recipe)
        {
            this.PlayerDatas[playerIndex].MakeAPoison(recipe);
        }
        public void OnPlayerUseSpell(int playerIndex, SpellCardData spellData)
        {

        }
    }
}