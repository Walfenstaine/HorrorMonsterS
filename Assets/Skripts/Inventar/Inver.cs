using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inver : MonoBehaviour
{
    public Image fon;
    public Text text;
    public Replic pred;
    public int index;
    public Data data;
    public Image img;

    private void Start()
    {
        img.sprite = data.predmets[index];
        img.transform.localPosition = Vector3.zero;
        Inventar.des += Destroy;
    }
    void Destroy()
    {
        Destroy(gameObject);
        Inventar.des -= Destroy;
    }
    public void SetPredmet() 
    {
        Inventar.rid.On_INVER();
        Tollse.rid.Indexer(index);
    }
    public void Enter()
    {
        if (data.language == "ru")
        {
            text.text = pred.repliks[index - 1].ru;
        }
        else
        {
            text.text = pred.repliks[index - 1].en;
        }
        fon.enabled = true;
    }
    public void Exit()
    {
        text.text = "";
        fon.enabled = false;
    }
}
