using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform playerSprite;
    public float cameraDistance = 30.0f;
    void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height/2)/cameraDistance);
    }
    void FixedUpdate()
    {
        transform.position = new Vector3(playerSprite.position.x, playerSprite.position.y, playerSprite.position.z - 20);

    }
}
