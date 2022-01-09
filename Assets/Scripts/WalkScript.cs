using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkScript : MonoBehaviour
{
    public int health = 3;
    float angle;
    float speed;
    public GameScript gameScript;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        speed = Random.Range(0.01f, 0.05f);
        angle = 0;
        transform.localPosition = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 translationVec = new Vector3(Mathf.Cos(angle),
                                              Mathf.Sin(angle),
                                              0);
        transform.localPosition += translationVec * speed;
        transform.rotation = Quaternion.Euler(0, 0, angle * (180 / Mathf.PI));
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            angle += 0.05f;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            angle -= 0.05f;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            speed = 0.1f;
        }
        else
        {
            speed = 0f;
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Monster")
        {
            this.gameObject.transform.localScale = new Vector3(0, 0, 0);
            gameScript.GameOver();
        }

    }
}
