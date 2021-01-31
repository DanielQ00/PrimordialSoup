using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeCombatRJD : MonoBehaviour
{
    //public Animator animator;
    // Start is called before the first frame update
    public Transform attackPoint;
    public LayerMask enemyLayers;

    public float attackRange = 0.5f;
    public int attackDamage = 40;

    public float attackRate = 2f;
    float nextAttackTime = 0f;

    



    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {


            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    void Attack()
    {
        //play attack anim code below uucomment when ready
        //animator.SetTrigger("Attack");

        //detect enemies in range

        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
        //damage them

        foreach(Collider enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyHealthRJD>().TakeDamage(attackDamage);
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}

