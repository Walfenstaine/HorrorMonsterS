
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Next_Lavel : MonoBehaviour
{
    public string nextLavel;
    public Data data;
    public UnityEvent nec;
    bool next = false;
    float timer = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            next = true;
            timer = Time.time + 5.0f;
            nec.Invoke();
        }
    }
    private void FixedUpdate()
    {
        if (next) 
        {
            if (Time.time >= timer) 
            {
                next = false;
                data.lavel = nextLavel;
                SaveAndLoad.instance.Save();
                SceneManager.LoadScene(nextLavel);
            }
        }
    }
}
