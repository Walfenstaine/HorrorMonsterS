using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Langwicher : MonoBehaviour
{
    public AudioClip clip;
    public string[] langviges;
    public Data data;
    public Slider slider;
    public Dropdown lang;

    private void Start()
    {
        for (int i = 0; i < langviges.Length; i++) 
        {
            if (langviges[i] == data.language) 
            {
                lang.value = i;
            }
        }
        slider.value = data.volume;
    }
    private void FixedUpdate()
    {
        data.volume = slider.value;
        AudioSource sorse = SoundPlayer.regit.sounds;
        sorse.volume = data.volume;
    }
    public void Onlang() 
    {
        int i = lang.value;
        data.language = langviges[i];
        PlayerPrefs.SetString("Langvich", data.language);
        PlayerPrefs.SetString("Language", langviges[i]);
        SoundPlayer.regit.Play_SOund(clip);
    }
}
