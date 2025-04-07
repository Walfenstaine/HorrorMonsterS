using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emiter : MonoBehaviour
{
    public GameObject emit;
    public float interval;
    float timer = 0;

    void Emit() 
    {
        Instantiate(emit, transform.position, Quaternion.identity);
    }

    private void FixedUpdate()
    {
        if (Time.time > timer) 
        {
            Emit();
            timer = Time.time + interval;
        }
    }
}
