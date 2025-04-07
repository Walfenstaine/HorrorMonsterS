using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animator anim;
    public Transform player, point;
    public GameObject[] points;
    float timer = 0;
    public float target_Timer = 0;

    private void Start()
    {
        points = GameObject.FindGameObjectsWithTag("Point");
        Onpoint();
    }
    public void Onpoint() 
    {
        Debug.Log("Onpoint");
        int i = Random.Range(0, points.Length);
        float f = Random.Range(0.5f, 2.5f);
        point = points[i].transform;
        timer = Time.time + f;
    }
    public void Target() 
    {
        target_Timer = 10.0f;
        player = Muwer.rid.transform;
    }
    public void Stoptarget() 
    {
        player = null;
        Onpoint();
    }
    private void FixedUpdate()
    {
        anim.SetFloat("Speed", agent.velocity.magnitude);
        if (timer <= Time.time)
        {
            if (agent.remainingDistance <= 1) 
            {
                Onpoint();
            }
            agent.isStopped = false;
            if (player != null)
            {
                agent.speed = 2;
                if (target_Timer > 0)
                {
                    target_Timer -= Time.deltaTime;
                }
                else 
                {
                    Stoptarget();
                }
                agent.destination = player.position;
            }
            else
            {
                agent.speed = 1;
                agent.destination = point.position;
            }
        }
        else 
        {
            agent.isStopped = true;
        }
        if (agent.velocity.magnitude <= 0.2f)
        {
            anim.SetBool("Walck", false);
        }
        else
        {
            anim.SetBool("Walck", true);
        }
        
    }
}
