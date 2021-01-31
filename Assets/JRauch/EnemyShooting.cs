using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyShooting : MonoBehaviour
{
    public enum State { Idle, Shooting };
    protected State curState;
    //protected NavMeshAgent myNavMeshAgent;
    GameObject target;
    [SerializeField] float dist;
    public float aggroDistance = 5;

    //WeaponBow Code
    public GameObject projectile; // To be attached to bow's projectile GameObject
    private GameObject firingPoint;
    public float fireSpeed = 0.5f;
    public float projectileSpeed = 7.0f;
    public float despawnTime = 5.0f;
    [SerializeField] bool canFire = true;


    public State state { get; set; }

    private void Start()
    {
        //myNavMeshAgent = GetComponent<NavMeshAgent>();
        target = GameObject.FindObjectOfType<PlayerMovement>().gameObject;
        firingPoint = transform.GetChild(2).gameObject;
    }

    private void Update()
    {
        CheckDistance();
        //Debug.Log(dist);
    }

    private void CheckDistance()
    {
        dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist <= aggroDistance && canFire)
        {
            transform.LookAt(new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z));
            Shoot();
            StartCoroutine(Reload());
        }
        else
        {
            state = State.Idle;
        }
    }
    private void Shoot()
    {
        state = State.Shooting;
        //myNavMeshAgent.isStopped = false;
        //myNavMeshAgent.rotation = target.transform.position;
        

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

    /*private void RotateEnemy()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);

        if (groundPlane.Raycast(ray, out float rayLength))
        {
            Vector3 pointToLook = ray.GetPoint(rayLength);

            
        }*/

    }
