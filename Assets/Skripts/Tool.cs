using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
    public AudioClip clip;
    public Replic pred;
    public Data data;
    public int index;
    private void Start()
    {
        for (int i = 0; i < data.indexes.Count; i++) 
        {
            if (index == data.indexes[i]) { Destroy(gameObject); }
        }
        for (int j = 0; j < data.indexesDan.Count; j++)
        {
            if (index == data.indexesDan[j]) { Destroy(gameObject); }
        }
    }
    public void OnDataIndex() 
    {
        SoundPlayer.regit.Play_SOund(clip);
        if (data.language == "ru")
        {
            Subtitres.rid.Masage(pred.repliks[index-1].ru);
        }
        else 
        {
            Subtitres.rid.Masage(pred.repliks[index-1].en);
        }
        data.indexes.Add(index);
        SaveAndLoad.instance.Save();
        Destroy(gameObject);
    }
}
