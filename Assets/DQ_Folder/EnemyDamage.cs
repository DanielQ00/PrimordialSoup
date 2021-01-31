using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    GameObject target;
    [SerializeField] int attackDamage;
    bool isInside;


    IEnumerator DealDamage(int damage)
    {
        while (isInside)
        {
            StartCoroutine(target.GetComponent<Health>().TakeDamage(damage));
            //Debug.Log("Damage Dealt");
            yield return new WaitForSeconds(0.5f);
        }
    }
    private void Start()
    {
        target = FindObjectOfType<PlayerMovement>().gameObject;

    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("EnterCollider");
        if (other.gameObject.GetComponent<PlayerMovement>())
        {
            isInside = true;
        }
        StartCoroutine("DealDamage", attackDamage);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerMovement>())
        {
            isInside = false;
        }
    }
}
