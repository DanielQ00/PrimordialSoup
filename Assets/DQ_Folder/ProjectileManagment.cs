using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManagment : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EnemyHealthRJD>())
        {

        }
        else
        {
            Debug.Log("Freezing");
        }
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }
}
