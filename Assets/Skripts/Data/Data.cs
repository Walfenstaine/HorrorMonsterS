using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Data", order = 1)]
public class Data : ScriptableObject
{
    public bool sound_On = true;
    public List<int> indexes;
    public List<int> indexesDan;
    public Sprite[] predmets;
    public string lavel = "Scene1";
    public string language = "ru";
    public float volume = 0.5f;
}