using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pelicas
{
    public class SC_MiniGameTest : MonoBehaviour
    {
        int points;
        [SerializeField] int amountNeeded;

        [SerializeField] GameObject pointButton;
        [SerializeField] GameObject youWonButton;

        private void Update()
        {
            if(points == amountNeeded)
            {
                pointButton.SetActive(false);
                youWonButton.SetActive(true);
            }
        }

        public void AddPoint()
        {
            points++;
        }

        public void ReturnToCity(string levelName)
        {
            SceneManager.LoadScene(levelName);
        }
    }

}
