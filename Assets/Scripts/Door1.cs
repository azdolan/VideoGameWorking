using UnityEngine;
using UnityEngine.Audio;

public class Door1 : MonoBehaviour
{
    public Animator animator;
    public Transform doorPoint;
    public float doorRange;
    public LayerMask doorLayer;
    public GameObject player;
    public AudioSource doorOpening;
    Inventory inventory;


    public void Update()
    {
        openDoor();
    }

    /*
     * This function will make the door animation play when certain events in the game are triggered 
     * 
     */

    public void openDoor()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            doorTrigger();
            Debug.Log("Test to see if door trigger is opened");

        }

    }

    /*
     * This function creates the parameters needed to be met before the door will open for the player
     */

    public void doorTrigger()
    {


        Collider2D[] doors = Physics2D.OverlapCircleAll(doorPoint.position, doorRange, doorLayer);
        Debug.Log(doorPoint.position + " " + doorRange + " " + doorLayer);
        Debug.Log("Number of doors in range" + doors.Length);

        foreach (Collider2D door in doors) // this loops for every item stored in the enemiesHit array
        {
            player = GameObject.Find("Player");
            

            if (Inventory.keyCount == 1) // if the player has one key in his inventory
            {
                animator.SetTrigger("DoorOpen"); // this makes the door animation play
                playAudio();
                Debug.Log("Door is open"); // for testing purposes to see if the animation plays               
            }

        }

    }

    /*
     * This function will play the audio of the door opening when it opens
     */
    public void playAudio()
    {
        doorOpening.Play();
    }


    void OnDrawGizmosSelected()
    {
        if (doorPoint == null)
        {
            return;
        }

        // this draws a sphere on the editor which makes it easiser for me to visulaise how the player attacks the enemy
        Gizmos.DrawWireSphere(doorPoint.position, doorRange);

    }
}
