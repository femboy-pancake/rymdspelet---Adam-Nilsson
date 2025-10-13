using UnityEngine;
using UnityEngine.UI;
public class PointCounterScript : MonoBehaviour
{

    public Text scoreText;

    int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
