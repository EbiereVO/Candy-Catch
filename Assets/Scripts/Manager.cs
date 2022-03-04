using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    int score = 0;
    bool gameOver = false;
    int lives = 3;
    public static Manager instance;
    public GameObject livesHolder;
    public GameObject gameoverPanel;

    public Text scoreText;

    void Awake()
    {
        instance = this;
        gameoverPanel.SetActive(false);
    }
   
    public void incrementScore()
    {
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
        }
    }

    public void DecreaseScore()
    {
        if (lives > 0)
        {
            lives--;
            Debug.Log(lives);
            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }

        if (lives <= 0)
        {
            gameOver = true;
            GameOver();
        }
    }

    public void GameOver()
    {
        Spawner.instance.stopSpawn();
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
        gameoverPanel.SetActive(true);
        Debug.Log("GameOver()");
    }
}
