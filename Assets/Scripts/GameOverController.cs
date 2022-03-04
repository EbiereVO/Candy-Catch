using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    // Start is called before the first frame update
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    public void mainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
