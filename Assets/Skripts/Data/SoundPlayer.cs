using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public SoundMixer mixer;
    public Data data;
    public AudioSource sounds;

    public static SoundPlayer regit { get; set; }
    private float tim;

    void Awake()
    {
        if (regit == null)
        {
            regit = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void OnDestroy()

    {
        regit = null;
    }

    public void Play_SOund(AudioClip id)
    {
        if (sounds.enabled)
        {
            if (Time.time > tim)
            {
                for (int i = 0; i < mixer.cenel.Length; i++) 
                {
                    if (mixer.cenel[i].clip.name == id.name) 
                    {
                        sounds.PlayOneShot(id, mixer.cenel[i].volume);
                    }
                }
               
                tim = Time.time + 0.1f;
            }
        }
        

    }
    private void FixedUpdate()
    {
        sounds.enabled = data.sound_On;
        sounds.volume = data.volume;
    }
}
