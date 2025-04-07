using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bloknot : MonoBehaviour
{
    public Image iM1, iM2;
    public AudioClip clip;
    public Text mass, prew;
    public Animator anim;
    public bool open = false;
    public static Bloknot rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    public void Demo() 
    {
        SoundPlayer.regit.Play_SOund(clip);
        
        open = !open;
        iM1.enabled = open;
        iM2.enabled = !open;
        anim.SetBool("Open", open);
    }
    public void OnMasage(string mas) 
    {
        SoundPlayer.regit.Play_SOund(clip);
        mass.text = mas;
        prew.text = mas;
    }
}
