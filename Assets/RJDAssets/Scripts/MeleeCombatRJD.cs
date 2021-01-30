using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeCombatRJD : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    void Attack()
    {
        //play attack anim
        //detect enemies in range
        //damage them
    }
}

