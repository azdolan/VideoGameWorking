using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyChest3 : MonoBehaviour
{
    public Animator animator;
    public Transform chestPoint;
    public float chestRange;
    public LayerMask keyChest3Layer;
    public GameObject keyChest;
    public AudioSource chestOpening;


    /*
     * This function will open the chest when the E key is pressed 
     */
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            chestTrigger();
        }
    }

    /*
     * This function creates the paremeters needed to be met before the chest will open for the player 
     */
    public void chestTrigger()
    {
        Collider2D[] chests = Physics2D.OverlapCircleAll(chestPoint.position, chestRange, keyChest3Layer);
        Debug.Log("Number of chests in range" + chests.Length);

        foreach (Collider2D chest in chests) // this loops for every item stored in the enemiesHit array
        {
            animator.SetTrigger("OpenChest"); //plays the chest opening animation
            keyChest = GameObject.Find("Player");
            //keyChest.GetComponent<Inventory>().keyFound(1);
            Inventory.keyCount += 1;
            playAudio();

        }
    }

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

