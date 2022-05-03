using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    private bool isAlive;
    private int currentHealth;
    public PlayerScore s;
    public GameObject player;
    EnemyAttack attack;
    public Text textBox;
    public AudioSource enemyDefeated;
    


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; //sets the enemy's current health to max
        isAlive = true;
    }     

    public void Damage(int enemyDamage)
    {
        // you can only die once
        if (currentHealth > 0)
        {
            currentHealth -= enemyDamage;
        }
        
       //if the enemy's current health is <= 0 and is alive is true
        if(currentHealth <= 0 && isAlive)
        {
            enemyDie(); //calls the function           
        }
    }

    /*
     * Function plays an animation when the enemy dies and adds to the player's score
     */
    void enemyDie()
    {

        Debug.Log("Enemy died");// for testing purposes to see if the enemy does die
        
        
        animator.SetBool("IsDead", true); // plays the die animation
        player = GameObject.Find("Player");       
        Score.score += 20;
        isAlive = false; // sets the enemy is alive bool to false so the player can't kill it again        
        playAudio();
    }

    public int GetEnemyHealth()
    {
        return this.currentHealth;
    }

    public void playAudio()
    {
        enemyDefeated.Play();
    }
    
}
