using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public GameObject target;
    [SerializeField] int attackDamage = 10;
    bool isInside;


    IEnumerator DealDamage(int damage)
    {
        while (isInside)
        {
            target.GetComponent<PlayerRJD>().TakeDamage(damage);
            Debug.Log("Damage Dealt");
            yield return new WaitForSeconds(0.5f);
        }
    }
    private void Start()
    {
        target = FindObjectOfType<PlayerMovement>().gameObject;

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("EnterCollider");
        if (other.gameObject.GetComponent<PlayerMovement>())
        {
            target = other.gameObject;
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
