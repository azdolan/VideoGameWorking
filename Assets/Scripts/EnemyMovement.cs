using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float characterMovement = 3f;
    public float rayDistance;
    bool rightDirection = true;
    public Transform endofRoute;
    public Animator animator;
    Enemy health;

    void Update()
    {
        health = this.GetComponent<Enemy>();

        //calls from the Enemy class to see if its health is >0 and if it is the enemy can move
        if (health.GetEnemyHealth() > 0)
        {
            moveEnemy();//calls the function
        }
    }   

    void moveEnemy()
    {
        
        transform.Translate(Vector2.left * characterMovement * Time.deltaTime);
        //Debug.Log("Moving along: " + characterMovement + " * " + Time.deltaTime);

        transform.Translate(Vector2.left * 3 * Time.deltaTime);
        

        RaycastHit2D bottom = Physics2D.Raycast(endofRoute.position, Vector2.down, rayDistance);

        //if the Raycast has not collided with anything 
        if (bottom.collider == false)
        {
            //Debug.Log("Collider: " + this.gameObject.name);
            //if the character is moving right
            if (rightDirection == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0); // turns the character around the face the other direction
                rightDirection = false;
               

            }
            // if the character is moving in the left direction
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                rightDirection = true;
            }
       }        

    }

}


