using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class SaveLoadJson : MonoBehaviour
{
    public GameObject HighScoreDisplay;
    private static int score;
    private static String date;
    private int InternalScore;
    private String InternalDate;

    private static string jsonSavePath;
    public static void LoadData()
    {
        ScoreSave scoreSave = JsonUtility.FromJson<ScoreSave>(File.ReadAllText(jsonSavePath));

       
        score = scoreSave.serializedScore;
        date = scoreSave.serializedDateTime;

        //Debug.Log((TimeSpan)(DateTime.UtcNow - DateTime.Parse(lemonSave.serializedDateTime)));

        //for testing
        Debug.Log("Score saved at: " + Score.ScoreCount);
       
        ScoreSave.loaded = true;
    }

    public static void SaveData()
    {
        //reference
        ScoreSave scoreSave = new ScoreSave();

        //lemonade
        scoreSave.serializedScore = Score.ScoreCount;
        ScoreSave.score = scoreSave.serializedScore;


        //Time
        scoreSave.serializedDateTime = DateTime.UtcNow.ToString("dd MMMM, yyyy");

        Debug.Log("Saving Score @: " + Score.ScoreCount);
        

        string jsonData = JsonUtility.ToJson(scoreSave, true);
        File.WriteAllText(jsonSavePath, jsonData);
        Debug.Log(jsonData);
    }

    void Start()
    {
        jsonSavePath = Application.persistentDataPath + "/cuberunner.json";
        Debug.Log(jsonSavePath);
        if (File.Exists(jsonSavePath))
        {
            SaveLoadJson.LoadData();
        }
    }
    void Update()
    {
        InternalDate = date;
        InternalScore = score;

        if (HighScoreDisplay != null)
        HighScoreDisplay.GetComponent<Text>().text = "Last Score: " + InternalScore + " Last Played: " + InternalDate;
    }

}

public class ScoreSave
{
    public int serializedScore;
    public static int score;
    
    public static bool loaded = false;
    public string serializedDateTime;
}
