using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Box : MonoBehaviour
{
    public AudioClip clip;

    public Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("Open", true);
            SoundPlayer.regit.Play_SOund(clip);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (anim != null)
            {
                anim.SetBool("Open", false);
                SoundPlayer.regit.Play_SOund(clip);
            }
        }
    }
}
