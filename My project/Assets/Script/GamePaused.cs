using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePaused : MonoBehaviour
{
    public GameObject MenuPause;
    public GameObject inf;
    public static bool gameIsPaused = false;
    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (!gameIsPaused)
            {
                Time.timeScale = 0.0f;
                gameIsPaused = true;
                MenuPause.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
            }


            else if (gameIsPaused)
            {
                Resume();
            }
        }
    }

    public void Resume()
    {
        MenuPause.SetActive(false);
        Time.timeScale = 1.0f;
        gameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1.0f;
        gameIsPaused = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
        gameIsPaused = false;
        Bullet.NbBullet = 45;
        Score.score = 0;
        Wave.nbWave = 1;
        VictoryDefeat.Win = false;
        Score.scoreMax = 25;
        Timer.timer = 0;
        inf.SetActive(false);
    }
}
