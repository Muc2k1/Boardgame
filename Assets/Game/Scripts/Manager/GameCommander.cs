using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElixirMaker.Definer;

namespace ElixirMaker.Manager
{
    public class GameCommander : MonoBehaviour //This class just for debug
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameController.Instance.DrawACard(0, ePlace.Imperial);
            }
        }
    }
}
