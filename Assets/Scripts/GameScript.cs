using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  
using Random = UnityEngine.Random;

public class GameScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject Button;
    public string alphabet;
    private string[] words = {"doughnut", "cashew"};
    private int randomizeIndex, life;
    private string hidden, randomizeWords, tempResult, guesses;

    // Start is called before the first frame update
    void Start()
    {
        Player.GetComponent<WalkScript>().gameScript = this;
        Button.GetComponent<GameButtonScript>().gameScript = this;
        randomizeIndex = Random.Range(0, words.Length);
        randomizeWords = words[randomizeIndex].Replace("", " ").ToUpper();
        hidden = randomizeWords.Replace("[A-Za-z0-9]", "_");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Escape();
        }
        
    }

    public void letterInputted()
    {
        for (int i = 0; i < randomizeWords.Length; i++)
        {
            string temp = randomizeWords[i].ToString();
            if (temp.Equals(alphabet)) {
                string temp2 = hidden[i].ToString();
                if (temp2.Equals(alphabet)) {
                    // Correct();
                } else {
                    hidden = hidden.Substring(0, i) + alphabet + hidden.Substring(i + 1);
                    tempResult = hidden;
                    if (!guesses.Contains(alphabet)) {
                        Guessed();
                    }
                    // End();
                }
            }
            if (i == randomizeWords.Length - 1 && !randomizeWords.Contains(alphabet)) {
                if (!guesses.Contains(alphabet)) {
                    // Wrong();
                    life--;
                    Guessed();
                }
            }
        }
    }

    public void Guessed()
    {

    }


    
    public void Escape()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);     
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   
    }
}
