using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveAndLoad : MonoBehaviour
{
    public Data data;
    public GameObject[] starter;
    public GameObject[] loader;
    public class MyList
    {
        public List<int> list;
    }
    public class MyList_dor
    {
        public List<int> list;
    }
    public static SaveAndLoad instance { get; set; }
    private void Start()
    {
        
        if (PlayerPrefs.HasKey("Language"))
        {
            data.language = PlayerPrefs.GetString("Language");
            for (int j = 0; j < loader.Length; j++)
            {
                loader[j].SetActive(true);
            }
            for (int i = 0; i < starter.Length; i++)
            {
                starter[i].SetActive(false);
            }
           
        }
        else 
        {
            for (int j = 0; j < loader.Length; j++)
            {
                loader[j].SetActive(false);
            }
            for (int i = 0; i < starter.Length; i++)
            {
                starter[i].SetActive(true);
            }
        }
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance.gameObject);
        }
    }


    public void StartGame() 
    {
        PlayerPrefs.DeleteAll();
        data.lavel = "CutScene1";
        data.indexes.Clear();
        data.indexesDan.Clear();
        Save();
        SceneManager.LoadScene(data.lavel);
        
    }
    public void LoadGame() 
    {
        string globalDataJSON = PlayerPrefs.GetString("Inventar");
        MyList loadedList = JsonUtility.FromJson<MyList>(globalDataJSON);
        for (int i = 0; i < loadedList.list.Count; i++)
        {
            data.indexes.Add(loadedList.list[i]);
        }

        string globalDataJSON_dor = PlayerPrefs.GetString("Dors");
        MyList_dor loadedList_dor = JsonUtility.FromJson<MyList_dor>(globalDataJSON_dor);
        for (int j = 0; j < loadedList_dor.list.Count; j++)
        {
            data.indexesDan.Add(loadedList_dor.list[j]);
        }

        data.language = PlayerPrefs.GetString("Language");
        SceneManager.LoadScene(PlayerPrefs.GetString("Level"));
    }
    public void Save() 
    {
        PlayerPrefs.SetString("Language", data.language);
        PlayerPrefs.SetString("Level", data.lavel);

        var listInClass = new MyList();
        listInClass.list = data.indexes;
        var outputString = JsonUtility.ToJson(listInClass);
        PlayerPrefs.SetString("Inventar", outputString);

        var listInClass_dor = new MyList_dor();
        listInClass_dor.list = data.indexesDan;
        var outputString_dor = JsonUtility.ToJson(listInClass_dor);
        PlayerPrefs.SetString("Dors", outputString_dor);
    }
    public void Maine() 
    {
        SceneManager.LoadScene("Menue");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
