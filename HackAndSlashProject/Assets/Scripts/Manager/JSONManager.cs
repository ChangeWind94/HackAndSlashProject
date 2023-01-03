using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JSONManager : MonoBehaviour
{

    string path;

    // Start is called before the first frame update
    void Start()
    {
        path = Path.Combine(Application.dataPath, "database.json");
        JsonLoad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JsonLoad()
    {
        JSONData saveData = new JSONData();

        if (!File.Exists(path))
        {
            
        }
        else
        {
            string loadJson = File.ReadAllText(path);
            saveData = JsonUtility.FromJson<JSONData>(loadJson);
        }
    }

    public void saveJson()
    {
        JSONData saveData = new JSONData();

        string json = JsonUtility.ToJson(saveData, true);

        File.WriteAllText(path, json);
    }

}
