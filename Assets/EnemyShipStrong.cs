using UnityEngine;
using System.Collections;
using TMPro;
public class EnemyShipStrong : MonoBehaviour
{
    public float speed;
    public GameObject EnemyStrongBulletScript;
    public float StrongBulletCooldown;
    public GameObject txtobj;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(StrongEnemyBullet());
    }
    private void Awake()
    {
        txtobj = GameObject.Find("Point Counter");
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
    private void OnTriggerEnter2D(Collider2D Other)
    {

    }
    public void TakeDamage()
    {
        txtobj.GetComponent<PointCounterScript>().Add_Points(2);
        Destroy(gameObject);
    }
}
