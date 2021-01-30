using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public enum State { Idle, Chasing, Attacking };
    protected State curState;
    protected NavMeshAgent myNavMeshAgent;
    GameObject target;
    [SerializeField] float dist;

    public State state { get; set; }

    private void Start()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        target = GameObject.FindObjectOfType<PlayerMovement>().gameObject;
    }

    private void Update()
    {
        CheckDistance();
        //Debug.Log(dist);
    }
    private void CheckDistance()
    {
        dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist <= 5 && dist>=2)
        {
            Chase();
        }
        else if(dist<2)
        {
            Attack();
        }
        else
        {
            state = State.Idle;
        }
    }
    private void Chase()
    {
        state = State.Chasing;
        myNavMeshAgent.isStopped = false;
        myNavMeshAgent.destination = target.transform.position;

    }
    private void Attack()
    {
        myNavMeshAgent.isStopped = true;
        state = State.Attacking;
    }



}
