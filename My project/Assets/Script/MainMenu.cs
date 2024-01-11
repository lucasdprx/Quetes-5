using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject SettingsWindow;
    public GameObject HelpWindow;
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Settings()
    {
        SettingsWindow.SetActive(true);
    }

    public void CloseSettings()
    {
        SettingsWindow.SetActive(false);
    }

    public void Help()
    {
        HelpWindow.SetActive(true);
    }

    public void CloseHelp()
    {
        HelpWindow.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
