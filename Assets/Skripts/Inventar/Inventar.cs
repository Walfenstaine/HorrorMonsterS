using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;

public class Inventar : MonoBehaviour
{
    public Data data;
    public GameObject predmet;
    public Transform[] poses;
    public Animator anim;
    public UnityEvent openInv;
    public UnityEvent closeInv;
    public static event Action des;
    bool open = false;
    public static Inventar rid { get; set; }
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
    public void On_INVER() 
    {
        open = !open;
        anim.SetBool("Open", open);
        Subtitres.rid.Close();
    }
    public void Open_Inv() 
    {
        openInv.Invoke();
        for (int i = 0; i < data.indexes.Count; i++)
        {
            if (data.indexes[i] > 0)
            {
                Inver inv = Instantiate(predmet).GetComponent<Inver>();
                inv.index = data.indexes[i];
                inv.transform.parent = poses[i].transform;
            }
        }
    }
    public void Close_Inv() 
    {
        closeInv.Invoke();
        des?.Invoke();
    }
}
