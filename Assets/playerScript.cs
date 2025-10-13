using Unity.VisualScripting;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float playerSpeed = 1.0f;
    public GameObject Bullet;
    public int health = 3;
    private GameObject Life1;
    private GameObject Life2;
    private GameObject Life3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        Life1 = GameObject.Find("life 1");
        Life2 = GameObject.Find("life 2");
        Life3 = GameObject.Find("life 3");
    }

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
   public void TakeDamage(int Damage)
    {
        health = health - Damage;
        if (health <= 0)
        {
            Destroy(gameObject);

        }
        if (health == 3)
        {
            if (GameObject.Find("Life 3") != null)
            Life3.SetActive(true);
            if (GameObject.Find("Life 2") != null)
                Life2.SetActive(true);
            if (GameObject.Find("Life 1") != null)
                Life1.SetActive(true);
        }

        else if (health == 2)
        {
            if (GameObject.Find("Life 3") != null)
                Life3.SetActive(false);
            if (GameObject.Find("Life 2") != null)
                Life2.SetActive(true);
            if (GameObject.Find("Life 1") != null)
                Life1.SetActive(true);
        }
        else if (health == 1)
        {
            if (GameObject.Find("Life 3") != null)
                Life3.SetActive(false);
            if (GameObject.Find("Life 2") != null)
                Life2.SetActive(false);
            if (GameObject.Find("Life 1") != null)
                Life1.SetActive(true);
        }
        else if (health <= 0)
        {
            if (GameObject.Find("Life 3") != null)
                Life3.SetActive(false);
            if (GameObject.Find("Life 2") != null)
                Life2.SetActive(false);
                        if (GameObject.Find("Life 1") != null)
            Life1.SetActive(false);
        }
        Life(health);

    }

    public void Life(int playerHealth)
    {
        Debug.Log("Life");
        
        if (playerHealth== 3)
        {
            if (GameObject.Find("life 3") != null)
                GameObject.Find("life 3").SetActive(true);
            if (GameObject.Find("life 2") != null)
                GameObject.Find("life 2").SetActive(true);
            if (GameObject.Find("life 1") != null)
                GameObject.Find("life 1").SetActive(true);
        }

        else if (playerHealth == 2)
        {
            if (GameObject.Find("life 3") != null)
                GameObject.Find("life 3").SetActive(false);
            if (GameObject.Find("life 2") != null)
                GameObject.Find("life 2").SetActive(true);
            if (GameObject.Find("life 1") != null)
                GameObject.Find("life 1").SetActive(true);
        }
        else if (playerHealth == 1)
        {
            if (GameObject.Find("life 3") != null)
                GameObject.Find("life 3").SetActive(false);
            if (GameObject.Find("life 2") != null)
                GameObject.Find("life 2").SetActive(false);
            if (GameObject.Find("life 1") != null)
                GameObject.Find("life 1").SetActive(true);
        }
        else if (playerHealth <= 0)
        {
            if (GameObject.Find("life 3") != null)
                GameObject.Find("life 3").SetActive(false);
            if (GameObject.Find("life 2") != null)
                GameObject.Find("life 2").SetActive(false);
            if (GameObject.Find("life 1") != null)
                GameObject.Find("life 1").SetActive(false);
        }
    }

}


 