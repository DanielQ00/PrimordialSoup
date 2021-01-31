using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAnim : MonoBehaviour
{
    public float attackSpeed = 0.3f;
    private float lastSwing = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Animator a = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time - lastSwing > attackSpeed)
        {
            lastSwing = Time.time;
            SwingSword();
        }
    }

    void SwingSword()
    {
        a.SetTrigger("Swing");
            
        //Destroy(swordSwing, 0.3f);
    }
}
