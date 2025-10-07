using Unity.VisualScripting;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float playerSpeed = 1.0f;
    public GameObject Bullet;
    public int health = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left *  playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }
       
       

        if (transform.position.x <= -12)
        {
            transform.position = new Vector3(12f, transform.position.y, -5);
        }
        else if (transform.position.x >= 12)
        {
            transform.position = new Vector3(-12f, transform.position.y, 5);
        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            Instantiate (Bullet, this.transform.position, this.transform.rotation); 
        }
    }
   public void TakeDamage()
    {
        health--;
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
    

}


 