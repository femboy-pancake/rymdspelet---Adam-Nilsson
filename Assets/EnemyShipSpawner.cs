using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyShipSpawner : MonoBehaviour
{
    public GameObject enemyShip;
    private int enemyCounter;
    private GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Spawner()

    {
        while (true)
        {
            if (enemyCounter < 10 && GameObject.Find("Player") != null)
            {
                Instantiate(enemyShip, new Vector3(Random.Range(-8, 8), 7, 0), Quaternion.identity);

                enemyCounter++;

                yield return new WaitForSeconds(2);

            }

            else yield return null;
        }
        
    }

    

}
