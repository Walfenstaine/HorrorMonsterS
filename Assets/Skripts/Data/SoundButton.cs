using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public Data data;
    public Image image;
    public Sprite on, off;
    public AudioSource sorse;

    public void Start()
    {
        if (data.sound_On)
        {
            image.sprite = on;
        }
        else
        {
            image.sprite = off;
        }
        //YandexGame.SaveProgress();
    }
    public void Onclicker() 
    {
        data.sound_On = !data.sound_On;
        if (data.sound_On) 
        {
            image.sprite = on;
        }
        else
        {
            image.sprite = off;
        }
    }
}
