using UnityEngine;
using System.Collections;

public class EnemyShipStrong : MonoBehaviour
{
    public float speed;
    public GameObject EnemyStrongBulletScript   ;
    public float StrongBulletCooldown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(StrongEnemyBullet());
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
    IEnumerator StrongEnemyBullet()
    {
        while (StrongBulletCooldown > 0)

        {
            Instantiate(EnemyStrongBulletScript, this.transform.position, this.transform.rotation);
            yield return new WaitForSeconds(StrongBulletCooldown);
        }
        yield return null;

    }

}
