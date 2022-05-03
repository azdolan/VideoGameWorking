using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
  
    public Animator animator;
    public Transform attackPoint;
    public float attackRange;
    public LayerMask enemyLayers;
    public int attackDamage = 40;
    public AudioSource sword;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // if the spacebar is pressed
        {

            Attack(); //calls the attack function

        }

       
    }

    void Attack()
    {
        animator.SetTrigger("Attack"); //plays the attack annimation 
        Debug.Log("Attack");

        Collider2D[] enemiesHit = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        Debug.Log("Number of enemies in range" + enemiesHit.Length);
        foreach (Collider2D enemy in enemiesHit) // this loops for every item stored in the enemiesHit array
        {

            enemy.GetComponent<Enemy>().Damage(attackDamage);
            playAudio();


        }
    }

        void OnDrawGizmosSelected()
        {
            if (attackPoint == null)
            {
                return;
            }

            // this draws a sphere on the editor which makes it easiser for me to visulaise how the player attacks the enemy
            Gizmos.DrawWireSphere(attackPoint.position, attackRange);

    }

    public void playAudio()
    {
        sword.Play();
    }
}

