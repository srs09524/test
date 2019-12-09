using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int ScoreCount;
    public GameObject ScoreDisplay;
    public int InternalScore;

    void Update()
    {
        InternalScore = ScoreCount;
        ScoreDisplay.GetComponent<Text>().text = " " + InternalScore;
    }
    private void Start()
    {
        ScoreCount = 0;
    }

}
