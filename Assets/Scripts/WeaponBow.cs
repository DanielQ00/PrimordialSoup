using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeaponBow : MonoBehaviour
{
    
    public GameObject projectile; // To be attached to bow's projectile GameObject

    public float fireSpeed = 0.5f;
    public float projectileSpeed = 7.0f;
    public float despawnTime = 5.0f;

    public float holdTime = 0.5f;
    private float holdStartTime;
    private bool holding = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ChargeFire();
    }
    void ChargeFire()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            holdStartTime = Time.time;
            holding = true;
        }
        if (Input.GetButtonUp("Fire2"))
        {
            holding = false;
        }
        if (holding && Time.time - holdStartTime > holdTime)
        {
            FireBow();
            holding = false;
        }
    }

    void FireBow()
    {
        GameObject projectileClone = Instantiate(projectile, transform.position, transform.rotation);
        Rigidbody rbody = projectileClone.GetComponent<Rigidbody>();

        rbody.velocity = rbody.transform.forward * projectileSpeed;

        // Destroy arrow 5 seconds after firing
        Destroy(projectileClone, 5);
    }

}
