using UnityEngine;

public class spelare : MonoBehaviour
{
    public GameObject Bullet;
    public float playerSpeed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.Space)) {
                Instantiate(Bullet, transform.position, transform.rotation);
            }
        }
    }
}
