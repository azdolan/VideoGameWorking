using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    
    public Transform doorPoint;
    public float interactionRange;
    public LayerMask doorLayer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            openDoor();
        }
    }

    void openDoor()
    {

    }
}