using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour
{
    public Text info;
    public Color red, green;
    public Language open, close;
    public Data data;
    void Start()
    {
        info.color = red;
        if (data.language == "ru")
        {
            info.text = close.ru;
        }
        else
        {
            info.text = close.en;
        }
    }
    public void Open() 
    {
        info.color = green;
        if (data.language == "ru")
        {
            info.text = open.ru;
        }
        else
        {
            info.text = open.en;
        }
    }
}
