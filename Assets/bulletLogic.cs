using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float bulletSpeed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Destroy(gameObject, 5);

    }

    // Update is called once per frame
    void Update()
    {


        {
            transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);

            if (transform.position.y > 8)
            {
                Destroy(gameObject);
            }

        }


    }
    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "enemy")
        {


            Other.transform.GetComponent<enemyShip>().TakeDamage();

            Debug.Log("Hit: " + Other);

            Destroy(gameObject);

        }

        else if (Other.tag == "StrongEnemy")
        {


            Other.transform.GetComponent<EnemyShipStrong>().TakeDamage();

            Debug.Log("Hit: " + Other);

            Destroy(gameObject);

        }
        //if (Other.tag != "Player" || Other.tag != "Laser")
            
    }

}
