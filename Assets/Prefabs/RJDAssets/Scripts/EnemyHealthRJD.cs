using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthRJD : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBarRJD healthBar;
    //public animator enemyanim;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        //animator.SetTrigger("Hurt");
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
        void Die()
        {
            Debug.Log("Enemy died!");
            //death animation
            //Animator.SetBool("IsDead", true);

            GetComponent<Collider>().enabled = false;
            this.enabled = false;


            //disable enemy
        }
    }
}
