using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pelicas
{
    public class SC_MarchandManager : MonoBehaviour
    {
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

        #region - PUBLIC_FUNCTIONS -

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
    }

}
