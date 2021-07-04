using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pelicas
{
    public class SC_ResourcesManager : MonoBehaviour
    {
        public int gold;
        public int wood;

        #region - UNITY_FUNCTIONS- 

        private void Awake()
        {
            gold = PlayerPrefs.GetInt("gold");
        }

        #endregion


        #region - PUBLIC_FUNCTIONS -
        #endregion


        #region - PRIVATE_FUNCTIONS -
        #endregion



    }
}

