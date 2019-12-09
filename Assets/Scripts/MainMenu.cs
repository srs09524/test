using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGameEasy () 
    {
        SceneManager.LoadScene(1);

    }

    public void PlayGameMed()
    {
        SceneManager.LoadScene(2);

    }

    public void PlayGameHard()
    {
        SceneManager.LoadScene(3);

    }
    public void ExitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
