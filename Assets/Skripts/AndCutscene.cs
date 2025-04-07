using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AndCutscene : MonoBehaviour
{
    public Data data;
    public string nextLavel;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void AndScene() 
    {
        data.lavel = nextLavel;
        SaveAndLoad.instance.Save();
        SceneManager.LoadScene(nextLavel);
    }
}
