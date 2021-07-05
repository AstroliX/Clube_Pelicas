using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pelicas
{
    public class SC_ResourcesManager : MonoBehaviour
    {
        #region Rare Resources
        public int diamond;
        public int pearl;
        public int exoFruit_1;
        public int exoFruit_2;
        public int exoLeaf_1;
        public int exoLeaf_2;
        public int reputPoint;
        #endregion

        #region Resources
        public int tomato;
        public int pepper;
        public int gold;
        public float crew;
        public int nativeGift;
        public int vanillaPlant;
        public int coconut;
        public int wood;
        public int iron;
        #endregion


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

