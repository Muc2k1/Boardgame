using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElixirMaker.Manager;

namespace ElixirMaker.Object
{
    public class PlayerBag : MonoBehaviour
    {
        private BagDisplay bagDisplay;
        private PlayerData owner;
        private void Start()
        {
            this.bagDisplay = GetComponent<BagDisplay>();    
        }
        public void UpdateBag()
        {
            this.bagDisplay.UpdateBag(owner);
        }
    }
}
