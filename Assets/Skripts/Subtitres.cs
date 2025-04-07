using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitres : MonoBehaviour
{
    public Image img;
    public Text text;
    float timer = 0;
    public static Subtitres rid { get; set; }
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
    public void Masage(string m) 
    {
        text.text = m;
        img.enabled = true;
        timer = Time.time + 3.5f;
    }
    public void Close() 
    {
        text.text = "";
        img.enabled = false;
        timer = 0;
    }
    private void FixedUpdate()
    {
        if (img.enabled) 
        {
            if (Time.time > timer) 
            {
                Close();
            }
        }
    }
}
