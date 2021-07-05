using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pelicas
{
    public class SC_NPCController : MonoBehaviour
    {
     
        [Header("Marchand")]
        [SerializeField] GameObject marchandPreview;


        SC_PlayerController playerScript;
        SC_CursorController cursorScript;


        #region - UNITY_FUNCTIONS -

        private void Awake()
        {
            playerScript = FindObjectOfType<SC_PlayerController>();
            cursorScript = FindObjectOfType<SC_CursorController>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                marchandPreview.SetActive(true);

            }
        }


        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    NPCisTalking();
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                marchandPreview.SetActive(false);
            }
        }

        #endregion


        #region - PUBLIC_FUNCTIONS -

        public void LeaveSetup()
        {

            cursorScript.DeactivateCursor();

            playerScript.canMove = true;
        }

        public void TradeResource()
        {

        }

        public void TradeRareResource()
        {

        }

        #endregion


        #region - PRIVATE_FUNCTIONS -

        void NPCisTalking()
        {
            playerScript.canMove = false;
            cursorScript.ActivateCursor();

            
        }

        #endregion






    }

}
