using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public AudioClip openS, closeS;
    public Data data;
    public Replic close, open;
    public Animator anim;
    public bool isOpen;

    public void Open() 
    {
        int i = Random.Range(0, open.repliks.Length);

        if (Time.time > 2) 
        {
            if (data.language == "ru")
            {
                Subtitres.rid.Masage(open.repliks[i].ru);
            }
            else
            {
                Subtitres.rid.Masage(open.repliks[i].en);
            }
            anim.SetBool("Open", true);
        }
    }
    public void Klamp() 
    {
        anim.SetBool("Open", true);
    }
    public void DorOpen() 
    {
        int i = Random.Range(0, open.repliks.Length);

        if (Time.time > 2)
        {
            if (data.language == "ru")
            {
                Subtitres.rid.Masage(open.repliks[i].ru);
            }
            else
            {
                Subtitres.rid.Masage(open.repliks[i].en);
            }
        }
        isOpen = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (isOpen)
        {
            if (other.tag == "Player")
            {
                anim.SetBool("Open", true);
                SoundPlayer.regit.Play_SOund(openS);
            }
        }
        else 
        {
            SoundPlayer.regit.Play_SOund(closeS);
            int i = Random.Range(0, close.repliks.Length);
            if (data.language == "ru")
            {
                Subtitres.rid.Masage(close.repliks[i].ru);
            }
            else
            {
                Subtitres.rid.Masage(close.repliks[i].en);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (isOpen) 
        {
            if (other.tag == "Player")
            {
                SoundPlayer.regit.Play_SOund(openS);
                anim.SetBool("Open", false);
            }
        }
    }
}
