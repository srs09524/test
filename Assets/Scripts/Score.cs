using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;

    private void OnTriggerEnter(Collider other)
    {
        theScore += 50;
        scoreText.GetComponent<Text>().text = " " + theScore;
        Destroy(gameObject);
    }
}
