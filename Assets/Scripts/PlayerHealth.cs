using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerHealth : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    public int currenthealth;
    public bool isAlive;
    public EndGameScreen endGameScreen;

    // creating globally accessible attribute so we can access it
    // from other scripts 
    public static event Action OnPlayerDeath;

    void Start()
    {
        currenthealth = maxHealth;
        isAlive = true;
        //health.maxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currenthealth <= 0 && isAlive)
        {
            endGameScreen.restartLevel();
            playerDie();
            Debug.Log("Player has died");
        }
    }

    void playerDie()
    {
        Debug.Log("Player died");
        animator.SetBool("isDead", true);
        isAlive = false;

        // Invoke game over
        OnPlayerDeath?.Invoke();
        
    }

    public void playerDamage(int damage)
    {
        currenthealth -= damage;
        Health.currentHealth -=damage;
        Debug.Log("Health: " + currenthealth);
    }

    public void increaseHealth(int increase)
    {
        currenthealth += increase;
        Health.currentHealth += increase;

        if (currenthealth > maxHealth)
        {
            currenthealth = maxHealth;
        }
    }
}