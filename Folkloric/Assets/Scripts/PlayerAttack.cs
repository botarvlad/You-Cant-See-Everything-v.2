using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float timeBtwAttk;
    public float startTimeBtwAttk;

    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage;

    public GameObject arma;

    private void Update()
    {
        if (timeBtwAttk <= 0)
        {
            if(Input.GetKey(KeyCode.Mouse0))
            {
                Collider2D[] enemyToDamage = Physics2D.OverlapCircleAll(attackPos.position,
                    attackRange, whatIsEnemies);
                for (int i = 0; i < enemyToDamage.Length; i++)
                {
                    enemyToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                }
                arma.SetActive(true);
            }

            timeBtwAttk = startTimeBtwAttk;
            
        }
        else
        {
            timeBtwAttk -= Time.deltaTime;
            arma.SetActive(false);
        }
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
