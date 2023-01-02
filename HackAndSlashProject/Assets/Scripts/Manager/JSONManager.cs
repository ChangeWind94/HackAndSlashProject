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
        SaveData saveData = new SaveData();

        if (!File.Exists(path))
        {
            GameManager.instance.playerGold = 100;
            GameManager.instance.playerPower = 4;
            SaveData();
        }
        else
        {
            string loadJson = File.ReadAllText(path);
            saveData = JsonUtility.FromJson<SaveData>(loadJson);

            if (saveData != null)
            {
                for (int i = 0; i < saveData.testDataA.Count; i++)
                {
                    GameManager.instance.testDataA.Add(saveData.testDataA[i]);
                }
                for (int i = 0; i < saveData.testDataB.Count; i++)
                {
                    GameManager.instance.testDataB.Add(saveData.testDataB[i]);
                }
                GameManager.instance.playerGold = saveData.gold;
                GameManager.instance.playerPower = saveData.power;
            }
        }
    }

    public void JsonSave()
    {
        SaveData saveData = new SaveData();

        for (int i = 0; i < 10; i++)
        {
            saveData.testDataA.Add("테스트 데이터 no " + i);
        }

        for (int i = 0; i < 10; i++)
        {
            saveData.testDataB.Add(i);
        }

        saveData.gold = GameManager.instance.playerGold;
        saveData.power = GameManager.instance.playerPower;

        string json = JsonUtility.ToJson(saveData, true);

        File.WriteAllText(path, json);
    }

}
