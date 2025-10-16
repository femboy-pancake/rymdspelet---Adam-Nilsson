using System.Collections;
using UnityEngine;
using TMPro;
using NUnit.Framework;
using System.Collections.Generic;
public class enemyShip : MonoBehaviour
{
    public float speed;
    public GameObject EnemyBullet;
    public float laserCooldown;
    public GameObject txtobj;


    [Header("loot")]
    public List<ShieldPickUpScript> lootTable = new List<ShieldPickUpScript>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Bullet());
    }

    private void Awake()
    {
        txtobj = GameObject.Find("Point Counter");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y <= -5.5f)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 5.5f, 0);

        }






    }
    IEnumerator Bullet()
    {
        while (laserCooldown > 0)

        {
            Instantiate(EnemyBullet, this.transform.position, this.transform.rotation);
            yield return new WaitForSeconds(laserCooldown);
        }
        yield return null;
    }
    private void OnTriggerEnter2D(Collider2D Other)
    {

    }
    public void TakeDamage()
    {
        txtobj.GetComponent<PointCounterScript>().Add_Points(1);

        foreach (ShieldPickUpScript ShieldPickUpScript in lootTable)
        {
            Debug.Log("INNE I FOREACH - TOBBE");
            if (Random.Range(0f, 100f) <= ShieldPickUpScript.dropchance)
            {
                Debug.Log("INNE I IF - TOBBE");
                Instantiateloot(ShieldPickUpScript.ShieldPickup);
                break;
            }
            
        }
        Destroy(gameObject);


    }

    public void Instantiateloot(GameObject loot)
    {
        if(loot)
        {
            GameObject droppedloot = Instantiate(loot, transform.position, Quaternion.identity);
        }

    }


   /*public void Instantiateloot(GameObject loot);
    {
    
    if(loot)
        {
          Gameobject droppedloot = Instantiate(loot, transform.position, Quaternion.identity);


          droppedLoot.getComponent<SpriteRenderer>().color = Color.red;
        }

    }*/
}

