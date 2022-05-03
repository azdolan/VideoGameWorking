using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public Vector3 behindPlayer; // this will create an offset and move the camera behind the player 


    void Update()
    {
        transform.position = player.position + behindPlayer;
    }
}
