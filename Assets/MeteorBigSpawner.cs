using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MeteorBigSpawner : MonoBehaviour
{
    
    public GameObject Meteor;
    private GameObject player;
    public int Meteorcounter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(MeteorSpawner());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator MeteorSpawner()

    {
        while (true)
        {
            if (Meteorcounter < 0 && GameObject.Find("Player") != null)
            {
                Instantiate(Meteor, new Vector3(Random.Range(-8, 8), 7, 0), Quaternion.identity);

                Meteorcounter++;

                yield return new WaitForSeconds(20);

            }

            else yield return null;
        }

    }
}