using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpener : MonoBehaviour
{
    BoxCollider coll;
    Animator a;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
        coll = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider c)
    {
        Debug.Log("Collision");
        if (c.tag == "Player")
        {
            
            a.SetTrigger("OpenChest");
        }
        
    }
}
