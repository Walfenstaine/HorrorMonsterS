using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PSSPanel : MonoBehaviour
{
    public UnityEvent<int> oK;
    public Opener opener;

    private void OnEnable()
    {
        Password.onOpoen += Open;
    }
    private void OnDisable()
    {
        Password.onOpoen -= Open;
    }
    void Open(int i) 
    {
        oK.Invoke(i);
    }
    public void AddPSS() 
    {
        Interface.rid.Sum(4);
        Password.rid.passvord = opener.index;
    }
}
