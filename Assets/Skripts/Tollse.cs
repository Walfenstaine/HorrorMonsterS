using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Tollse : MonoBehaviour
{
    public Image cell, tool;
    public int index;
    public Data data;
    public static Tollse rid { get; set; }
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
    public void Indexer(int i) 
    {
        index = i;
        tool.sprite = data.predmets[index];
    }
}
