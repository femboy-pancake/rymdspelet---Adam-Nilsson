using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PointCounterScript : MonoBehaviour
{
    public TMP_Text scoreText;



    public int points = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        this.GetComponent<TMP_Text>().text = points.ToString() + " POINTS";
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Add_Points(int point)
    {
        points = points + point;
        this.GetComponent<TMP_Text>().text = points.ToString() + " POINTS";
    }

}
