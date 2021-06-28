using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pelicas
{
    public class SC_NPCController : MonoBehaviour
    {
        [Header("GameObjects")]
        [SerializeField] GameObject showResources;

        [SerializeField] GameObject beforeTalking_1;
        [SerializeField] GameObject beforeTalking_2;
        [SerializeField] GameObject txt;
        [SerializeField] GameObject buttonReturn;
        [SerializeField] GameObject buttonPlay;


        SC_PlayerController playerScript;
        SC_CursorController cursorScript;

        private void Awake()
        {
            playerScript = FindObjectOfType<SC_PlayerController>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Player")
            {
                showResources.SetActive(true);
            
            }
        }


        private void OnTriggerStay(Collider other)
        {
            if(other.gameObject.tag == "Player")
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    SetupMiniGame();
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                showResources.SetActive(false);
            }
        }

        void SetupMiniGame()
        {
            playerScript.canMove = false;
            //cursorScript.ActivateCursor();

            beforeTalking_1.SetActive(false);
            beforeTalking_2.SetActive(false);
            txt.SetActive(true);
            buttonReturn.SetActive(true);
        }

        public void LeaveSetup()
        {
            
            //cursorScript.DeactivateCursor();

            beforeTalking_1.SetActive(true);
            beforeTalking_2.SetActive(true);
            txt.SetActive(false);
            buttonReturn.SetActive(false);

            playerScript.canMove = true;
        }
    }

}
