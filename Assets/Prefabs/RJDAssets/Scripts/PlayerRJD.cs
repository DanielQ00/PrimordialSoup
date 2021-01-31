using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRJD : MonoBehaviour
{
    //public Animator playerAnim;
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBarRJD healthBar;
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

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0)
        {
            PlayerDeath();
        }
        void PlayerDeath()
        {
            Debug.Log("Player died!");
            //death animation
            //Animator.SetBool("IsDead", true);

            GetComponent<Collider>().enabled = false;
            this.enabled = false;


            //disable enemy
        }
    }
    
}
