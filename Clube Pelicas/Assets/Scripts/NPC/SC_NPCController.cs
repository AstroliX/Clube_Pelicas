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
        [SerializeField] GameObject marchandIsTalking;

        [Space]
        [Header("Cameras")]
        [SerializeField] GameObject playerCam;
        [SerializeField] GameObject npcCam;

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
            marchandIsTalking.SetActive(false);


            playerCam.SetActive(true);
            npcCam.SetActive(false);
            playerScript.canMove = true;
        }

        
        

        #endregion


        #region - PRIVATE_FUNCTIONS -

        void NPCisTalking()
        {
            playerCam.SetActive(false);
            npcCam.SetActive(true);

            playerScript.canMove = false;
            cursorScript.ActivateCursor();

            marchandPreview.SetActive(false);
            marchandIsTalking.SetActive(true);
        }

        #endregion






    }

}
