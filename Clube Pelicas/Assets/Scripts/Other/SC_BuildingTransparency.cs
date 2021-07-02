using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pelicas
{
    public class SC_BuildingTransparency : MonoBehaviour
    {
        [SerializeField] GameObject solidBody;
        [SerializeField] GameObject transparentBody;



        #region UNITY_FUNCTIONS
        #endregion


        #region PUBLIC_FUNCTIONS
        #endregion


        #region PRIVATE_FUNCTIONS
        #endregion

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
