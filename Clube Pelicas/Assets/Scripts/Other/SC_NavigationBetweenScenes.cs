using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pelicas
{
    public class SC_NavigationBetweenScenes : MonoBehaviour
    {

        [Header("Where are we sending the player ?")]
        public bool isSendingToTown;
        public bool isSendingToHarbor;
        public bool isSendingToKing;

        [Space]
        [Header("Where will the player arrived ?")]
        [SerializeField] GameObject arrivedInHarbor;


        Transform T_player;

        #region - UNITY_FUNCTIONS -

        private void Start()
        {
            T_player = GameObject.FindGameObjectWithTag("Player").transform;
        }


        public void OnTriggerEnter(Collider other)
        {
            if (isSendingToHarbor)
            {
                if(other.gameObject.tag == "Player")
                {
                    GoToHarbor();
                }
            }

            if (isSendingToKing)
            {
                if (other.gameObject.tag == "Player")
                {
                    Debug.Log("AAAAAAAAAAAAH");
                }
            }
        }
        #endregion


        #region - PUBLIC_FUNCTIONS -
        #endregion


        #region - PRIVATE_FUNCTIONS -

        void GoToTown()
        {
            
        }

        void GoToKing()
        {

        }

        void GoToHarbor()
        {
            T_player.position = arrivedInHarbor.transform.position;
        }

        #endregion

    }


}

