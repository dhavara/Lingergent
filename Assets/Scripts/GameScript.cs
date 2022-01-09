using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class GameScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Escape();
        }
        
    }
    
    public void Escape()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);     
    }
}
