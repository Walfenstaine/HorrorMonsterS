using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Opener : MonoBehaviour
{
    public UnityEvent open,opener;
    public Animator anim;
    public int index;
    public Data data;
    bool op = false;
    private void Start()
    {
        for (int i = 0; i < data.indexesDan.Count; i++)
        {
            if (index == data.indexesDan[i]) 
            {
                open.Invoke();
                op = true;
            }
        }
    }
    public void Opened() 
    {
        op = true;
        open.Invoke();
        data.indexesDan.Add(index);
        SaveAndLoad.instance.Save();
    }
    public void Open(int ind) 
    {
        if (!op)
        {
            if (ind == index)
            {
                if (anim != null)
                {
                    anim.SetFloat("Speed", 1);
                }
                else { Opened(); }
                for (int i = 0; i < data.indexes.Count; i++)
                {
                    if (data.indexes[i] == ind)
                    {
                        data.indexes.RemoveAt(i);
                    }
                }
            }
            else
            {
                Inventar.rid.On_INVER();
            }
        }
        else { opener.Invoke(); }
    }
}
