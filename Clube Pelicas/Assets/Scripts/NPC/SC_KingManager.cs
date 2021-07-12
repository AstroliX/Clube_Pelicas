using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pelicas
{
    public class SC_KingManager : MonoBehaviour
    {
        [Header("King Main Menu")]
        [SerializeField] GameObject text_mainMenu;
        [SerializeField] GameObject buttonYes_mainMenu;
        [SerializeField] GameObject buttonNo_mainMenu;

        [Space]
        [SerializeField] GameObject tradingMenu;

        [Space]
        [SerializeField] GameObject youDontHaveEnough;

        [Space]
        [Header("How many reput points is an item worth")]
        [SerializeField] int rareValue;
        [SerializeField] int normalValue;


        SC_ResourcesManager resource;

        #region - UNITY_FUNCTIONS -

        private void Awake()
        {
            resource = FindObjectOfType<SC_ResourcesManager>();
        }

        IEnumerator YouDontHaveEnough()
        {
            youDontHaveEnough.SetActive(true);
            yield return new WaitForSeconds(3);
            youDontHaveEnough.SetActive(false);
        }

        #endregion


        #region - PUBLIC_FUNCTIONS -

        public void GoToTradingMenu()
        {
            text_mainMenu.SetActive(false);
            buttonNo_mainMenu.SetActive(false);
            buttonYes_mainMenu.SetActive(false);
            tradingMenu.SetActive(true);
        }

        public void LeaveTradingMenu()
        {
            tradingMenu.SetActive(false);
            text_mainMenu.SetActive(true);
            buttonNo_mainMenu.SetActive(true);
            buttonYes_mainMenu.SetActive(true);
            
        }

        public void SellDiamond_1()
        {

            if(resource.diamond >= 1)
            {
                resource.diamond -= 1;
                resource.reputPoint += rareValue;

                PlayerPrefs.SetInt("diamond", resource.diamond);
                PlayerPrefs.SetInt("reputPoint", resource.reputPoint);
            }
            else
            {
                StartCoroutine(YouDontHaveEnough());
            }

        }

        public void SellPearl_1()
        {
            if(resource.pearl >= 1)
            {
                resource.pearl -= 1;
                resource.reputPoint += rareValue;

                PlayerPrefs.SetInt("pearl", resource.pearl);
                PlayerPrefs.SetInt("reputPoint", resource.reputPoint);
            }
            else
            {
                StartCoroutine(YouDontHaveEnough());
            }
            

        }

        public void SellDExoFruit1_1()
        {
            if(resource.exoFruit_1 >= 1)
            {
                resource.exoFruit_1 -= 1;
                resource.reputPoint += rareValue;

                PlayerPrefs.SetInt("exoFruit_1", resource.exoFruit_1);
                PlayerPrefs.SetInt("reputPoint", resource.reputPoint);
            }
            else
            {
                StartCoroutine(YouDontHaveEnough());
            }


        }

        public void SellDExoFruit2_1()
        {

            if(resource.exoFruit_2 >= 1)
            {
                resource.exoFruit_2 -= 1;
                resource.reputPoint += rareValue;

                PlayerPrefs.SetInt("exoFruit_2", resource.exoFruit_2);
                PlayerPrefs.SetInt("reputPoint", resource.reputPoint);
            }
            else
            {
                StartCoroutine(YouDontHaveEnough());
            }
            

        }


        public void SellDExoLeaf1_1()
        {
            if(resource.exoLeaf_1 >= 1)
            {
                resource.exoLeaf_1 -= 1;
                resource.reputPoint += rareValue;

                PlayerPrefs.SetInt("exoLeaf_1", resource.exoLeaf_1);
                PlayerPrefs.SetInt("reputPoint", resource.reputPoint);
            }
            else
            {
                StartCoroutine(YouDontHaveEnough());
            }
            

        }

        public void SellDExoLeaf2_1()
        {
            if(resource.exoLeaf_2 >= 1)
            {
                resource.exoLeaf_2 -= 1;
                resource.reputPoint += rareValue;

                PlayerPrefs.SetInt("exoLeaf_2", resource.exoLeaf_2);
                PlayerPrefs.SetInt("reputPoint", resource.reputPoint);
            }
            else
            {
                StartCoroutine(YouDontHaveEnough());
            }



        }


        public void SellDiamond_5()
        {
            if(resource.diamond >= 5)
            {
                resource.diamond -= 5;
                resource.reputPoint += rareValue * 5;

                PlayerPrefs.SetInt("diamond", resource.diamond);
                PlayerPrefs.SetInt("reputPoint", resource.reputPoint);
            }
            else
            {
                StartCoroutine(YouDontHaveEnough());
            }
            

        }

        public void SellPearl_5()
        {
            if(resource.pearl >= 5)
            {
                resource.pearl -= 5;
                resource.reputPoint += rareValue * 5;

                PlayerPrefs.SetInt("pearl", resource.pearl);
                PlayerPrefs.SetInt("reputPoint", resource.reputPoint);
            }
            else
            {
                StartCoroutine(YouDontHaveEnough());
            }
            

        }

        public void SellDExoFruit1_5()
        {
            if(resource.exoFruit_1 >= 5)
            {
                resource.exoFruit_1 -= 5;
                resource.reputPoint += rareValue * 5;

                PlayerPrefs.SetInt("exoFruit_1", resource.exoFruit_1);
                PlayerPrefs.SetInt("reputPoint", resource.reputPoint);
            }
            else
            {
                StartCoroutine(YouDontHaveEnough());
            }

           

        }

        public void SellDExoFruit2_5()
        {
            if(resource.exoFruit_2 >= 5)
            {
                resource.exoFruit_2 -= 5;
                resource.reputPoint += rareValue * 5;

                PlayerPrefs.SetInt("exoFruit_2", resource.exoFruit_2);
                PlayerPrefs.SetInt("reputPoint", resource.reputPoint);
            }
            else
            {
                StartCoroutine(YouDontHaveEnough());
            }
            

        }


        public void SellDExoLeaf1_5()
        {
            if(resource.exoLeaf_1 >= 5)
            {
                resource.exoLeaf_1 -= 5;
                resource.reputPoint += rareValue * 5;

                PlayerPrefs.SetInt("exoLeaf_1", resource.exoLeaf_1);
                PlayerPrefs.SetInt("reputPoint", resource.reputPoint);
            }
            else
            {
                StartCoroutine(YouDontHaveEnough());
            }

            

        }

        public void SellDExoLeaf2_5()
        {
            if(resource.exoLeaf_2 >= 5)
            {
                resource.exoLeaf_2 -= 5;
                resource.reputPoint += rareValue * 5;

                PlayerPrefs.SetInt("exoLeaf_2", resource.exoLeaf_2);
                PlayerPrefs.SetInt("reputPoint", resource.reputPoint);
            }
            else
            {
                StartCoroutine(YouDontHaveEnough());
            }
            

        }
        #endregion

        #region - PRIVATE_FUNCTIONS -

        

        #endregion


    }
}


