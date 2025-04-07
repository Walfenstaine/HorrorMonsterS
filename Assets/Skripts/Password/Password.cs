using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class Password : MonoBehaviour
{
    public Data data;
    public Language ok, no;
    public int passvord;
    public string str;
    public Text txt;
    public static event Action<int> onOpoen;
    public static Password rid { get; set; }
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


    void Update()

    {
        if(str == "")
        {
            txt.text = "_";
        }
        else
        {
            txt.text = str;
        }
    }

    public void Button(int code)

    {
        if (str.Length < 4)
        {
            str += code;
        }
        else { Delete(); }
    }

    public void Delete()

    {
        if(str != "")
        {
            str = "";
        }
    }

    public void Check() 

    {
        int i = int.Parse(str);
        if (str == passvord.ToString())
        {
            if (data.language == "ru")
            {
                str = ok.ru;
            }
            else
            {
                str = ok.en;
            }
            onOpoen.Invoke(i);
        }
        else
        {
            if (data.language == "ru")
            {
                str = no.ru;
            }
            else
            {
                str = no.en;
            }
        }
    }

}
