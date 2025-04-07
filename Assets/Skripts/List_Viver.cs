using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List_Viver : MonoBehaviour
{
    public Data data;
    public Language masage;
    public void Open_List() 
    {
        Interface.rid.Sum(5);
        if (data.language == "ru")
        {
            Bloknot.rid.OnMasage(masage.ru);
        }
        else 
        {
            Bloknot.rid.OnMasage(masage.en);
        }
    }
}
