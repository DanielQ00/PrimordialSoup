using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManagment : MonoBehaviour
{
    public int damage =25;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EnemyHealthRJD>())
        {
            Debug.Log("Sending Damage");
            collision.gameObject.GetComponent<EnemyHealthRJD>().TakeDamage(damage);
        }
        else
        {
            Debug.Log("Freezing");
        }
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        GetComponent<BoxCollider>().enabled = false;
    }
}
