using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pelicas
{
    public class SC_BuildingTransparency : MonoBehaviour
    {
        [SerializeField] GameObject solidBody;
        [SerializeField] GameObject transparentBody;

        private void Awake()
        {
            ShowSolid();
        }

        public void ShowTransparency()
        {
            solidBody.SetActive(false);
            transparentBody.SetActive(true);
        }

        public void ShowSolid()
        {
            solidBody.SetActive(true);
            transparentBody.SetActive(false);
        }
    }

}
