using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Vector3 tsel;
    public Transform target;
    public NavMeshAgent agent;
    public Animator anim;
    float timer = 0;

    private void Start()
    {
        NewPosition();
    }
    void NewPosition() 
    {
        tsel = new Vector3(Random.Range(-45, 45),0, Random.Range(-45, 45));
        agent.isStopped = false;
    }

    private void FixedUpdate()
    {
        anim.SetBool("Run", !agent.isStopped);
        if (target == null)
        {
            agent.destination = tsel;
        }
        else 
        {
            agent.destination = target.position;
        }
        if (!agent.isStopped)
        {
            if (Vector3.Distance(transform.position, agent.destination) < 0.1f)
            {
                agent.isStopped = true;
                timer = Time.time + 4;
            }
        }
        else 
        {
            if (Time.time > timer) 
            {
                NewPosition();
            }
        }
    }
}
