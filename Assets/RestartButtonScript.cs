using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonScript : MonoBehaviour
{


    public void RestartGame() 
    {
    
        SceneManager.LoadScene("SampleScene");
        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            
        }

    }
}

