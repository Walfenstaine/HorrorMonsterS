using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour {
	public AudioClip[] clip;
    public void Step()
    {
        int num = Random.Range(0, clip.Length-1);
        float volum = Vector3.Distance(transform.position, Camera.main.transform.position);
        if (volum < 15.0f)
        {
            SoundPlayer.regit.Play_SOund(clip[num]);
        }
        
    }
}
