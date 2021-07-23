using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyBoundary
{
    public float miniY, maxiY;

    
}

public class IslandManager : MonoBehaviour
{
    [Header("References")]
    public EnemyBoundary eBoundary;
    [SerializeField] GameObject[] asteroids;
    //[SerializeField] GameObject enemy;
  
    [Space]
    [Header("Stats")]
    public float timer = 2f;




    void Start()
    {




    }


    void Spawner()
    {
        float pos_Y = Random.Range(eBoundary.miniY, eBoundary.maxiY);
        Vector3 temp = transform.position;
        temp.y = pos_Y;

        if (Random.Range(0, 2) > 0)
        {
            Instantiate(asteroids[Random.Range(0, asteroids.Length)], temp, Quaternion.identity);
        }
        /*else
        {
            Instantiate(enemy, temp, Quaternion.Euler(0f, 0f, 90f));
        }*/

      //  timer = Random.Range(1f, 2f);

        Invoke("Spawner", timer);
    }
}
