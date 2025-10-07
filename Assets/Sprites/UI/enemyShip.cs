using System.Collections;
using UnityEngine;

public class enemyShip : MonoBehaviour
{
    public float speed;
    public GameObject EnemyBullet;
    public float laserCooldown;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Bullet());
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
         if(Other.tag == "bullet") 
         {

             TakeDamage();

             Debug.Log("Hit: " + Other);

             Destroy(gameObject);
         }
     }
    public void TakeDamage()
    {

        Destroy(gameObject);
    }


}

