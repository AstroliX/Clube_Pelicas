using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pelicas
{
    public class SC_ResourcesManager : MonoBehaviour
    {
        public int gold;
        public int wood;

        private void Awake()
        {
            gold = PlayerPrefs.GetInt("gold");
        }

    }
}

