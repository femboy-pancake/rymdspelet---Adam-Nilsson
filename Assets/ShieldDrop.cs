using UnityEngine;

public class ShieldDrop : MonoBehaviour
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
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);

            if (transform.position.y <= -5.5f)
            {
                transform.position = new Vector3(Random.Range(-8, 8), 5.5f, 0);

            }
        }
    }
}
