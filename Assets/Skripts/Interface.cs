using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Interface : MonoBehaviour
{
    public UnityEvent[] sumer;
    public static Interface rid { get; set; }
    void Awake()
    {
        Sum(1);
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
    public void Sum(int index) 
    {
        sumer[index].Invoke();
        if (index == 1)
        {
            CursorEvent(false);
        }
        else 
        {
            CursorEvent(true);
        }
    }
    public void CursorEvent(bool activ)
    {
        if (Muwer.rid)
        {
            Muwer.rid.muve = Vector3.zero;
            Muwer.rid.rute = Vector2.zero;
            if (activ)
            {
                Time.timeScale = 0;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Time.timeScale = 1;
                Cursor.lockState = CursorLockMode.Locked;
            }
            Cursor.visible = activ;
        }
        else 
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
