using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 150;

    public IEnumerator TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            if (gameObject.GetComponent<EnemyMovement>())
            {
                EnemyDeath();
            }
            else if (GetComponent<PlayerMovement>())
            {
                PlayerDeath();
            }
        }
        yield break;
    }
    private void EnemyDeath()
    {

    }
    private void PlayerDeath()
    {

    }

}
