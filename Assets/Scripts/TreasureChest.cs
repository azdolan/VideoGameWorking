using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Class Summary
 * This class contains functions for the health chest in the game
 */
public class TreasureChest : MonoBehaviour
{
    public Animator animator;
    public Transform chestPoint;
    public float chestRange;
    public LayerMask chestLayer;
    public GameObject healthChest;    
    public bool isOpen = false;
    public AudioSource chestOpening;

    /*
     * This function will open the chest when the E key is pressed
     */
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isOpen)
        {
            chestTrigger();
        }
    }

    /*
     * This function creates the parameters needed to be met before the chest will open
     */
    public void chestTrigger()
    {

        Collider2D[] chests = Physics2D.OverlapCircleAll(chestPoint.position, chestRange, chestLayer); // creates an array 
        Debug.Log("Number of chests in range" + chests.Length); //for testing purposes to see if the player is in range of a chest

        foreach (Collider2D chest in chests) // this loops for every item stored in the enemiesHit array
        {
            animator.SetTrigger("OpenChest"); //plays the chest opening animation
            healthChest = GameObject.Find("Player");
            //  healthChest.GetComponent<PlayerHealth>().increaseHealth(10);
            Score.score += 50; //increases the player score by 50

            playAudio();
            isOpen = true; // sets the bool to true which stops players from opening it multiple times
        }
    }

    /*
     * This function plays the audoio from the audio soruce
     */
    public void playAudio()
    {
        chestOpening.Play();
    }

    void OnDrawGizmosSelected()
    {
        if (chestPoint == null)
        {
            return;
        }

        // this draws a sphere on the editor which makes it easiser for me to visulaise how the player attacks the enemy
        Gizmos.DrawWireSphere(chestPoint.position, chestRange);

    }
}

