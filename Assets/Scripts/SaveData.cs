using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[Serializable]
public class SaveData
{
    public string maxiumumPlayerName;
    public int maximumPlayerScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Save()
    {
        SaveData data = new SaveData();
        data.maxiumumPlayerName = MainManager.maxiumumPlayerName;
        data.maximumPlayerScore = MainManager.maximumPlayerScore;

        string json = JsonUtility.ToJson(data);
    
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public static void Load()
    {
        Debug.Log(Application.persistentDataPath + "/savefile.json");
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            MainManager.maxiumumPlayerName = data.maxiumumPlayerName;
            MainManager.maximumPlayerScore = data.maximumPlayerScore;
        }
    }


}
