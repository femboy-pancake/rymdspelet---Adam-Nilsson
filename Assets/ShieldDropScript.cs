using UnityEngine;

public class ShieldDropScript : MonoBehaviour



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
    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {

            Other.transform.GetComponent<playerScript>().TakeDamage(0);

            Debug.Log("Hit: " + Other);

            Destroy(gameObject);

        }
    }
}
