using UnityEngine;

public class enemyShip : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

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
    private void OnTriggerEnter2D(Collider2D Other)
    {
        if(Other.tag == "player") 
        {

            Other.transform.GetComponent<playerScript>().TakeDamage();

            Debug.Log("Hit: " + Other);
        }
    }

}

