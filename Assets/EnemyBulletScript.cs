using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
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
            transform.Translate(Vector3.down * bulletSpeed * Time.deltaTime);

            if (transform.position.y > 8)
            {
                Destroy(gameObject);
            }


        }

    }
    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {

            Other.transform.GetComponent<playerScript>().TakeDamage(1);

            Debug.Log("Hit: " + Other);

            Destroy(gameObject);

        }
    }

}

