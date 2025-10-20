using UnityEngine;

public class ShieldScript : MonoBehaviour

{
    public int health = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);

        }
    }
    public void TakeDamage(int Damage)
    {
        health = health - Damage;
        if (health <= 0)
        {
            Destroy(gameObject);

        }
    }
    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "EnemyBullet")
        {


            Other.transform.GetComponent<enemyShip>().TakeDamage();

            Debug.Log("Hit: " + Other);

            Destroy(gameObject);

        }

        else if (Other.tag == "EnemyStrongBullet")
        {


            Other.transform.GetComponent<EnemyShipStrong>().TakeDamage();

            Debug.Log("Hit: " + Other);

            Destroy(gameObject);

        }


    }
}


   

