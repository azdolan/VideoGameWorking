using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange;
    public LayerMask playerLayer;
    public int attackDamage = 1;
    Enemy health;
    

    public float attackFrequency = 0.01f;
    float attackTime = 0f;



    void Update()
    {
        health = this.GetComponent<Enemy>();

        if(Time.time >= attackTime && health.GetEnemyHealth() >0)
        {

            Attack();
            attackTime = Time.time + 1f / attackFrequency;

        }
    }
    

    void Attack()
    {
        

        Collider2D[] playerHit = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayer);
        

        foreach (Collider2D player in playerHit)
        {

            player.GetComponent<PlayerHealth>().playerDamage(attackDamage);
            
        }

    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
