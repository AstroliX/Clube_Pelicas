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
            diamond = PlayerPrefs.GetInt("diamond");
            pearl = PlayerPrefs.GetInt("pearl");
            exoFruit_1 = PlayerPrefs.GetInt("exoFruit_1");
            exoFruit_2 = PlayerPrefs.GetInt("exoFruit_2");
            exoLeaf_1 = PlayerPrefs.GetInt("exoLeaf_1");
            exoLeaf_2 = PlayerPrefs.GetInt("exoLeaf_2");
            reputPoint = PlayerPrefs.GetInt("reputPoint");

            gold = PlayerPrefs.GetInt("gold");

            tomato = PlayerPrefs.GetInt("tomato");
            pepper = PlayerPrefs.GetInt("pepper");
            crew = PlayerPrefs.GetInt("crew");
            nativeGift = PlayerPrefs.GetInt("nativeGift");
            vanillaPlant = PlayerPrefs.GetInt("vanillaPlant");
            coconut = PlayerPrefs.GetInt("coconut");
            wood = PlayerPrefs.GetInt("wood");
            iron = PlayerPrefs.GetInt("iron");
        }

        #endregion


        #region - PUBLIC_FUNCTIONS -
        #endregion


        #region - PRIVATE_FUNCTIONS -
        #endregion



    }
}

