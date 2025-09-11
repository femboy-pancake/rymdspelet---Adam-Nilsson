using UnityEngine;

public class bullet : MonoBehaviour
{
    public float BulletSpeed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            transform.Translate(Vector3.up * BulletSpeed * Time.deltaTime);
    }
}
