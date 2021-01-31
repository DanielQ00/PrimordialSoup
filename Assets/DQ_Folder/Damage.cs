using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    GameObject target;
    [SerializeField] int attackDamage;
   
    IEnumerator DealDamage(int damage)
    {
        StartCoroutine(target.GetComponent<Health>().TakeDamage(damage));
        yield break;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<EnemyMovement>())
        {
            target = collision.gameObject;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
