using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    int score = 0;
    bool GameOver = false;
    public static Manager instance;

    void Awake()
    {
        instance = this;
    }
   
    public void incrementScore()
    {
        score++;
        Debug.Log(score);
    }
}
