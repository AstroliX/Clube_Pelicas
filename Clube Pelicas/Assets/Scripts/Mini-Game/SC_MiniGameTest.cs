using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pelicas
{
    public class SC_MiniGameTest : MonoBehaviour
    {
        int points;
        [SerializeField] int amountNeeded;

        private void Update()
        {
            if(points == amountNeeded)
            {
                Debug.Log("You won gg wp");
            }
        }

        public void AddPoint()
        {
            points++;
        }
    }

}
