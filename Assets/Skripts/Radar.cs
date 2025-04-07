using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Radar : MonoBehaviour
{
    public float distanse = 10;
    public UnityEvent target;

    private void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, - transform.forward);
        if (Physics.Raycast(ray, out hit, distanse)) 
        {
            if (hit.collider.tag == "Player") 
            {
                target.Invoke();
            }
        }
    }
}
