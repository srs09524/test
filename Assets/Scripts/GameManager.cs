﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timeLeft = 30.0f;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }
   
    #region Singleton
    public static GameManager Instance;
    public void Score()
    {
        score++;

    }
    #endregion
}
