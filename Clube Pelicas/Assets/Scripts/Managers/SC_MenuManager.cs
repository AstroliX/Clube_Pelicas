using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace Pelicas
{
    public class SC_MenuManager : MonoBehaviour
    {
        int gold;

        Transform T_player;

        [Header("Show amount of resources")]
        [SerializeField] TextMeshProUGUI goldScore;

        SC_ResourcesManager resourcesScript;


        #region - UNITY_FUNCTIONS -
        private void Awake()
        {
            resourcesScript = FindObjectOfType<SC_ResourcesManager>();
        }

        private void Start()
        {
            T_player = GameObject.FindGameObjectWithTag("Player").transform;
        }



        public void Update()
        {
            gold = resourcesScript.gold;
            goldScore.text = gold + " Gold";
        }

 

        #endregion


        #region - PUBLIC_FUNCTIONS -
        #endregion


        #region - PRIVATE_FUNCTIONS -
        #endregion



    }
}

