using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButtonScript : MonoBehaviour
{
    private string letter;
    public GameScript gameScript;
    // Start is called before the first frame update
    void Start()
    {
        letter = "A";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player") {
            if (Input.GetKey(KeyCode.E))
            {
                gameScript.alphabet = letter;
                gameScript.letterInputted();
            }
        }
    }
    
}
