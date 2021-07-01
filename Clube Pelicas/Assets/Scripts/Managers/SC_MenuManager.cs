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

        [SerializeField] TextMeshProUGUI goldScore;

        SC_ResourcesManager resourcesScript;

        private void Awake()
        {
            resourcesScript = FindObjectOfType<SC_ResourcesManager>();
        }

        

        public void Update()
        {
            gold = resourcesScript.gold;
            goldScore.text = gold + " Gold";
        }
    }
}

