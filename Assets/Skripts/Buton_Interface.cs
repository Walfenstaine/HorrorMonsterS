using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buton_Interface : MonoBehaviour
{
    public Data data;
    public void Starter() 
    {
        SaveAndLoad.instance.StartGame();
    }
    public void Resume() 
    {
        SaveAndLoad.instance.LoadGame();
    }
    public void Main()
    {
        data.indexes.Clear();
        data.indexesDan.Clear();
        if (Muwer.rid) 
        {
            PlayerPrefs.SetFloat("PL_pos_x", Muwer.rid.transform.position.x);
            PlayerPrefs.SetFloat("PL_pos_y", Muwer.rid.transform.position.y);
            PlayerPrefs.SetFloat("PL_pos_z", Muwer.rid.transform.position.z);
            PlayerPrefs.SetFloat("PL_rut", Muwer.rid.transform.eulerAngles.y);
        }
       
        SaveAndLoad.instance.Maine();
    }
    public void Quit()
    {
        SaveAndLoad.instance.Quit();
    }
}
