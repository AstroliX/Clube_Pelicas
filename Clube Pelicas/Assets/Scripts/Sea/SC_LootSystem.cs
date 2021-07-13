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
        public ItemToSpawn[] itemToSpawn_1;
        public ItemToSpawn[] itemToSpawn_2;
        public ItemToSpawn[] itemToSpawn_3;

        SC_LootedItemSlot lootedItem;

        #region - UNITY_FUNCTIONS -

        private void Awake()
        {
            lootedItem = FindObjectOfType<SC_LootedItemSlot>();
        }

        void Start()
        {
            if(PlayerPrefs.GetInt("hull") == 0)
            {
                for (int i = 0; i < itemToSpawn_1.Length; i++)
                {

                    if (i == 0)
                    {
                        itemToSpawn_1[i].minSpawnProb = 0;
                        itemToSpawn_1[i].maxSpawnProb = itemToSpawn_1[i].spawnRate - 1;
                    }
                    else
                    {
                        itemToSpawn_1[i].minSpawnProb = itemToSpawn_1[i - 1].maxSpawnProb + 1;
                        itemToSpawn_1[i].maxSpawnProb = itemToSpawn_1[i].minSpawnProb + itemToSpawn_1[i].spawnRate - 1;
                    }
                }
            }

            if (PlayerPrefs.GetInt("hull") == 1)
            {
                for (int i = 0; i < itemToSpawn_2.Length; i++)
                {

                    if (i == 0)
                    {
                        itemToSpawn_2[i].minSpawnProb = 0;
                        itemToSpawn_2[i].maxSpawnProb = itemToSpawn_2[i].spawnRate - 1;
                    }
                    else
                    {
                        itemToSpawn_2[i].minSpawnProb = itemToSpawn_2[i - 1].maxSpawnProb + 1;
                        itemToSpawn_2[i].maxSpawnProb = itemToSpawn_2[i].minSpawnProb + itemToSpawn_2[i].spawnRate - 1;
                    }
                }
            }


            if (PlayerPrefs.GetInt("hull") == 2)
            {
                for (int i = 0; i < itemToSpawn_3.Length; i++)
                {

                    if (i == 0)
                    {
                        itemToSpawn_3[i].minSpawnProb = 0;
                        itemToSpawn_3[i].maxSpawnProb = itemToSpawn_3[i].spawnRate - 1;
                    }
                    else
                    {
                        itemToSpawn_3[i].minSpawnProb = itemToSpawn_3[i - 1].maxSpawnProb + 1;
                        itemToSpawn_3[i].maxSpawnProb = itemToSpawn_3[i].minSpawnProb + itemToSpawn_3[i].spawnRate - 1;
                    }
                }
            }


        }


        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(PlayerPrefs.GetInt("hull") == 0)
                {
                    SpawnnerHull_1();
                }

                if (PlayerPrefs.GetInt("hull") == 1)
                {
                    SpawnnerHull_2();
                }

                if (PlayerPrefs.GetInt("hull") == 2)
                {
                    SpawnnerHull_3();
                }

            }
        }

        #endregion

        #region - PRIVATE_FUNCTIONS -
        void SpawnnerHull_1()
        {
            float randomNum = Random.Range(0, 100);

            for (int i = 0; i < itemToSpawn_1.Length; i++)
            {
                if (randomNum >= itemToSpawn_1[i].minSpawnProb && randomNum <= itemToSpawn_1[i].maxSpawnProb)
                {

                    if(PlayerPrefs.GetInt("stock") == 0)
                    {
                        for (int e = 0; e < lootedItem.slots_1.Length; e++)
                        {
                            if (lootedItem.isFull_1[e] == false)
                            {
                                Instantiate(itemToSpawn_1[i].item, lootedItem.slots_1[e].transform, false);
                                lootedItem.isFull_1[e] = true;
                                break;
                            }
                        }
                    }


                    if (PlayerPrefs.GetInt("stock") == 1)
                    {
                        for (int e = 0; e < lootedItem.slots_2.Length; e++)
                        {
                            if (lootedItem.isFull_2[e] == false)
                            {
                                Instantiate(itemToSpawn_1[i].item, lootedItem.slots_2[e].transform, false);
                                lootedItem.isFull_2[e] = true;
                                break;
                            }
                        }
                    }


                    if (PlayerPrefs.GetInt("stock") == 2)
                    {
                        for (int e = 0; e < lootedItem.slots_3.Length; e++)
                        {
                            if (lootedItem.isFull_3[e] == false)
                            {
                                Instantiate(itemToSpawn_1[i].item, lootedItem.slots_3[e].transform, false);
                                lootedItem.isFull_3[e] = true;
                                break;
                            }
                        }
                    }

                }
            }
        }


        void SpawnnerHull_2()
        {
            float randomNum = Random.Range(0, 100);

            for (int i = 0; i < itemToSpawn_2.Length; i++)
            {
                if (randomNum >= itemToSpawn_2[i].minSpawnProb && randomNum <= itemToSpawn_2[i].maxSpawnProb)
                {

                    if (PlayerPrefs.GetInt("stock") == 0)
                    {
                        for (int e = 0; e < lootedItem.slots_1.Length; e++)
                        {
                            if (lootedItem.isFull_1[e] == false)
                            {
                                Instantiate(itemToSpawn_2[i].item, lootedItem.slots_1[e].transform, false);
                                lootedItem.isFull_1[e] = true;
                                break;
                            }
                        }
                    }


                    if (PlayerPrefs.GetInt("stock") == 1)
                    {
                        for (int e = 0; e < lootedItem.slots_2.Length; e++)
                        {
                            if (lootedItem.isFull_2[e] == false)
                            {
                                Instantiate(itemToSpawn_2[i].item, lootedItem.slots_2[e].transform, false);
                                lootedItem.isFull_2[e] = true;
                                break;
                            }
                        }
                    }


                    if (PlayerPrefs.GetInt("stock") == 2)
                    {
                        for (int e = 0; e < lootedItem.slots_3.Length; e++)
                        {
                            if (lootedItem.isFull_3[e] == false)
                            {
                                Instantiate(itemToSpawn_2[i].item, lootedItem.slots_3[e].transform, false);
                                lootedItem.isFull_3[e] = true;
                                break;
                            }
                        }
                    }

                }
            }
        }


        void SpawnnerHull_3()
        {
            float randomNum = Random.Range(0, 100);

            for (int i = 0; i < itemToSpawn_3.Length; i++)
            {
                if (randomNum >= itemToSpawn_3[i].minSpawnProb && randomNum <= itemToSpawn_3[i].maxSpawnProb)
                {

                    if (PlayerPrefs.GetInt("stock") == 0)
                    {
                        for (int e = 0; e < lootedItem.slots_1.Length; e++)
                        {
                            if (lootedItem.isFull_1[e] == false)
                            {
                                Instantiate(itemToSpawn_3[i].item, lootedItem.slots_1[e].transform, false);
                                lootedItem.isFull_1[e] = true;
                                break;
                            }
                        }
                    }


                    if (PlayerPrefs.GetInt("stock") == 1)
                    {
                        for (int e = 0; e < lootedItem.slots_2.Length; e++)
                        {
                            if (lootedItem.isFull_2[e] == false)
                            {
                                Instantiate(itemToSpawn_3[i].item, lootedItem.slots_2[e].transform, false);
                                lootedItem.isFull_2[e] = true;
                                break;
                            }
                        }
                    }


                    if (PlayerPrefs.GetInt("stock") == 2)
                    {
                        for (int e = 0; e < lootedItem.slots_3.Length; e++)
                        {
                            if (lootedItem.isFull_3[e] == false)
                            {
                                Instantiate(itemToSpawn_3[i].item, lootedItem.slots_3[e].transform, false);
                                lootedItem.isFull_3[e] = true;
                                break;
                            }
                        }
                    }

                }
            }
        }

        #endregion

    }
}

