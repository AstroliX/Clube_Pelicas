using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pelicas
{
    public class SC_MarchandManager : MonoBehaviour
    {
        #region GameObjects Menu
        [Space]
        [Header("MENU 1")]
        [SerializeField] GameObject menu_SELL;
        [SerializeField] GameObject menu_BUY;

        [Header("MENU 1: BUTTON")]
        [SerializeField] GameObject button_SELL;
        [SerializeField] GameObject button_BUY;

        [Space]
        [Header("MENU SELL 1: BUTTON")]
        [SerializeField] GameObject button_rareItems_SELL;
        [SerializeField] GameObject button_items_SELL;

        [Space]
        [Header("RETURN TO MENU SELL 1")]
        [SerializeField] GameObject button_wasRareItemNowReturn_SELL;
        [SerializeField] GameObject button_wasItemNowReturn_SELL;

        [SerializeField] GameObject button_wasRareItemNowReturn_BUY;
        [SerializeField] GameObject button_wasItemNowReturn_BUY;

        [Space]
        [Header("MENU SELL 1")]
        [SerializeField] GameObject menu_rareItem_SELL;
        [SerializeField] GameObject menu_item_SELL;
        [SerializeField] GameObject fb_YouDontHaveThisItem;
        #endregion

        #region Rare Items Value

        [SerializeField] int diamondValue;
        [SerializeField] int pearlValue;
        [SerializeField] int exoFruit_1Value;
        [SerializeField] int exoFruit_2Value;
        [SerializeField] int exoLeaf_1Value;
        [SerializeField] int exoLeaf_2Value;
        [SerializeField] int reputPointValue;

        #endregion

        #region Items Value

        [SerializeField] int tomatoValue;
        [SerializeField] int pepperValue;
        [SerializeField] int nativeGiftValue;
        [SerializeField] int vanillaPlantValue;
        [SerializeField] int coconutValue;
        [SerializeField] int woodValue;
        [SerializeField] int ironValue;

        #endregion

        SC_ResourcesManager resourceManager;

        #region - UNITY_FUNCTIONS -

        private void Awake()
        {
            resourceManager = FindObjectOfType<SC_ResourcesManager>();
        }

        IEnumerator YouDontHaveThisItem()
        {
            fb_YouDontHaveThisItem.SetActive(true);
            yield return new WaitForSecondsRealtime(2);
            fb_YouDontHaveThisItem.SetActive(false);
        }

        #endregion

        #region - PUBLIC_FUNCTIONS -

        #region Menu Functions

        public void GoingToSell()
        {
            button_BUY.SetActive(false);
            button_SELL.SetActive(false);
            menu_SELL.SetActive(true);
        }

        public void GoingToBuy()
        {
            button_BUY.SetActive(false);
            button_SELL.SetActive(false);
            menu_BUY.SetActive(true);
        }

        public void WasSellingNowReturn()
        {
            menu_SELL.SetActive(false);
            button_BUY.SetActive(true);
            button_SELL.SetActive(true);
        }

        public void WasBuyingNowReturn()
        {
            menu_BUY.SetActive(false);
            button_BUY.SetActive(true);
            button_SELL.SetActive(true);
        }

        public void GoingToSellRareItems()
        {
            button_rareItems_SELL.SetActive(false);
            button_items_SELL.SetActive(false);

            button_wasRareItemNowReturn_SELL.SetActive(true);
            menu_rareItem_SELL.SetActive(true);
        }

        public void GoingToSellItems()
        {
            button_rareItems_SELL.SetActive(false);
            button_items_SELL.SetActive(false);

            button_wasItemNowReturn_SELL.SetActive(true);
            menu_item_SELL.SetActive(true);
        }

        public void WasRareItemNowReturn()
        {
            button_rareItems_SELL.SetActive(true);
            button_items_SELL.SetActive(true);

            button_wasRareItemNowReturn_SELL.SetActive(false);
            menu_rareItem_SELL.SetActive(false);
        }

        public void WasItemNowReturn()
        {
            button_rareItems_SELL.SetActive(true);
            button_items_SELL.SetActive(true);

            button_wasRareItemNowReturn_SELL.SetActive(false);
            menu_rareItem_SELL.SetActive(false);
        }

        #endregion


        #region Selling Rare Items Functions

        public void SellDiamond()
        {
            if(resourceManager.diamond != 0)
            {
                resourceManager.diamond -= 1;

                resourceManager.gold += diamondValue;

                PlayerPrefs.SetInt("diamond", resourceManager.diamond);
                PlayerPrefs.SetInt("gold", resourceManager.gold);
            }
            else
            {
                StartCoroutine(YouDontHaveThisItem());
            }
            

        }

        public void SellPearl()
        {
            if (resourceManager.pearl != 0)
            {
                resourceManager.pearl -= 1;

                resourceManager.gold += pearlValue;

                PlayerPrefs.SetInt("pearl", resourceManager.pearl);
                PlayerPrefs.SetInt("gold", resourceManager.gold);
            }
            else
            {
                StartCoroutine(YouDontHaveThisItem());
            }


        }

        public void SellExoFruit1()
        {
            if (resourceManager.exoFruit_1 != 0)
            {
                resourceManager.exoFruit_1 -= 1;

                resourceManager.gold += exoFruit_1Value;

                PlayerPrefs.SetInt("exoFruit_1", resourceManager.exoFruit_1);
                PlayerPrefs.SetInt("gold", resourceManager.gold);
            }
            else
            {
                StartCoroutine(YouDontHaveThisItem());
            }


        }

        public void SellExoFruit2()
        {
            if (resourceManager.exoFruit_2 != 0)
            {
                resourceManager.exoFruit_2 -= 1;

                resourceManager.gold += exoFruit_1Value;

                PlayerPrefs.SetInt("exoFruit_2", resourceManager.exoFruit_2);
                PlayerPrefs.SetInt("gold", resourceManager.gold);
            }
            else
            {
                StartCoroutine(YouDontHaveThisItem());
            }


        }

        public void SellExoLeaf1()
        {
            if (resourceManager.exoLeaf_1 != 0)
            {
                resourceManager.exoLeaf_1 -= 1;

                resourceManager.gold += exoLeaf_1Value;

                PlayerPrefs.SetInt("exoLeaf_1", resourceManager.exoLeaf_1);
                PlayerPrefs.SetInt("gold", resourceManager.gold);
            }
            else
            {
                StartCoroutine(YouDontHaveThisItem());
            }


        }


        public void SellExoLeaf2()
        {
            if (resourceManager.exoLeaf_2 != 0)
            {
                resourceManager.exoLeaf_2 -= 1;

                resourceManager.gold += exoLeaf_2Value;

                PlayerPrefs.SetInt("exoLeaf_2", resourceManager.exoLeaf_2);
                PlayerPrefs.SetInt("gold", resourceManager.gold);
            }
            else
            {
                StartCoroutine(YouDontHaveThisItem());
            }


        }



        #endregion

        #region Selling Items Functions

        public void SellTomato()
        {
            if (resourceManager.tomato != 0)
            {
                resourceManager.tomato -= 1;

                resourceManager.gold += tomatoValue;

                PlayerPrefs.SetInt("tomato", resourceManager.tomato);
                PlayerPrefs.SetInt("gold", resourceManager.gold);
            }
            else
            {
                StartCoroutine(YouDontHaveThisItem());
            }


        }

        public void SellPepper()
        {
            if (resourceManager.pepper != 0)
            {
                resourceManager.pepper -= 1;

                resourceManager.gold += pepperValue;

                PlayerPrefs.SetInt("pepper", resourceManager.pepper);
                PlayerPrefs.SetInt("gold", resourceManager.gold);
            }
            else
            {
                StartCoroutine(YouDontHaveThisItem());
            }


        }

        public void SellNativeGift()
        {
            if (resourceManager.nativeGift != 0)
            {
                resourceManager.nativeGift -= 1;

                resourceManager.gold += nativeGiftValue;

                PlayerPrefs.SetInt("nativeGift", resourceManager.nativeGift);
                PlayerPrefs.SetInt("gold", resourceManager.gold);
            }
            else
            {
                StartCoroutine(YouDontHaveThisItem());
            }


        }

        public void SellVanillaPlant()
        {
            if (resourceManager.vanillaPlant != 0)
            {
                resourceManager.vanillaPlant -= 1;

                resourceManager.gold += vanillaPlantValue;

                PlayerPrefs.SetInt("vanillaPlant", resourceManager.vanillaPlant);
                PlayerPrefs.SetInt("gold", resourceManager.gold);
            }
            else
            {
                StartCoroutine(YouDontHaveThisItem());
            }


        }

        public void SellCoconut()
        {
            if (resourceManager.coconut != 0)
            {
                resourceManager.coconut -= 1;

                resourceManager.gold += coconutValue;

                PlayerPrefs.SetInt("coconut", resourceManager.coconut);
                PlayerPrefs.SetInt("gold", resourceManager.gold);
            }
            else
            {
                StartCoroutine(YouDontHaveThisItem());
            }


        }


        public void SellWood()
        {
            if (resourceManager.wood != 0)
            {
                resourceManager.wood -= 1;

                resourceManager.gold += woodValue;

                PlayerPrefs.SetInt("wood", resourceManager.wood);
                PlayerPrefs.SetInt("gold", resourceManager.gold);
            }
            else
            {
                StartCoroutine(YouDontHaveThisItem());
            }


        }


        public void SellIron()
        {
            if (resourceManager.iron != 0)
            {
                resourceManager.iron -= 1;

                resourceManager.gold += woodValue;

                PlayerPrefs.SetInt("iron", resourceManager.iron);
                PlayerPrefs.SetInt("gold", resourceManager.gold);
            }
            else
            {
                StartCoroutine(YouDontHaveThisItem());
            }


        }

        #endregion

        #endregion

        #region - PRIVATE_FUNCTIONS -


        #endregion
    }

}
