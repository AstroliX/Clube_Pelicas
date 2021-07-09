using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pelicas
{
    [System.Serializable]
    public class ItemToSpawn
    {
        public GameObject item;
        public float spawnRate;
        [HideInInspector] public float minSpawnProb, maxSpawnProb;
    }

    public class SC_LootSystem : MonoBehaviour
    {
        public ItemToSpawn[] itemToSpawn;

        SC_LootedItemSlot lootedItem;

        #region - UNITY_FUNCTIONS -

        private void Awake()
        {
            lootedItem = FindObjectOfType<SC_LootedItemSlot>();
        }

        void Start()
        {

            for (int i = 0; i < itemToSpawn.Length; i++)
            {

                if (i == 0)
                {
                    itemToSpawn[i].minSpawnProb = 0;
                    itemToSpawn[i].maxSpawnProb = itemToSpawn[i].spawnRate - 1;
                }
                else
                {
                    itemToSpawn[i].minSpawnProb = itemToSpawn[i - 1].maxSpawnProb + 1;
                    itemToSpawn[i].maxSpawnProb = itemToSpawn[i].minSpawnProb + itemToSpawn[i].spawnRate - 1;
                }
            }
            

        }


        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Spawnner();
            }
        }

        #endregion

        #region - PRIVATE_FUNCTIONS -
        void Spawnner()
        {
            float randomNum = Random.Range(0, 100);

            for (int i = 0; i < itemToSpawn.Length; i++)
            {
                if (randomNum >= itemToSpawn[i].minSpawnProb && randomNum <= itemToSpawn[i].maxSpawnProb)
                {
                    for (int e = 0; e < lootedItem.slots.Length; e++)
                    {
                        if(lootedItem.isFull[e] == false)
                        {
                            Instantiate(itemToSpawn[i].item, lootedItem.slots[e].transform, false);
                            lootedItem.isFull[e] = true;
                            break;
                        }
                    }

                    //Instantiate(itemToSpawn[i].item, transform.position, Quaternion.identity);
                    //break;
                }
            }
        }

        #endregion

    }
}

