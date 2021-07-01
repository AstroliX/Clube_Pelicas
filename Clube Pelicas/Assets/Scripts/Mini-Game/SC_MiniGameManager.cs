using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pelicas
{
    public class SC_MiniGameManager : MonoBehaviour
    {
        public bool wonMiniGame;
        public bool lostMiniGame;


        private void Awake()
        {
            wonMiniGame = (PlayerPrefs.GetInt("wonMiniGame") != 0);
            lostMiniGame = (PlayerPrefs.GetInt("lostMiniGame") != 0);
        }


        public void HeWon()
        {
            PlayerPrefs.SetInt("wonMiniGame", (wonMiniGame ? 1 : 0));
            wonMiniGame = true;
            
        }
    }
}

