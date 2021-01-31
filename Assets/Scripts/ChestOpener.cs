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
        coll = GetComponentInChildren<BoxCollider>();
        a = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Chest opening");
        a.SetTrigger("OpenChest");
    }
}
