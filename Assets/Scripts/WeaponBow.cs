using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeaponBow : MonoBehaviour
{

    public GameObject projectile; // To be attached to bow's projectile GameObject
    private GameObject firingPoint;
    public float fireSpeed = 0.5f;
    public float projectileSpeed = 7.0f;
    public float despawnTime = 5.0f;
    [SerializeField] bool canFire = true;

    // Start is called before the first frame update
    void Start()
    {
        firingPoint = transform.GetChild(2).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canFire)
        {
            FireBow();
            StartCoroutine(Reload());
        }
    }

    void FireBow()
    {
        canFire = false;
        GameObject projectileClone = Instantiate(projectile, firingPoint.transform.position, transform.rotation);
        Rigidbody rbody = projectileClone.GetComponent<Rigidbody>();

        rbody.velocity = transform.forward * projectileSpeed;

        // Destroy arrow 5 seconds after firing
        Destroy(projectileClone, 5);
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(fireSpeed);
        canFire = true;
    }
}
