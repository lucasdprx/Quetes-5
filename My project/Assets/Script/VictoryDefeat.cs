using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryDefeat : MonoBehaviour
{
    [SerializeField] private GameObject victoryDefeattext;
    public static bool Win = false;
    public GameObject UiVD;
    public GameObject TextTimer;

    void Update()
    {
        victoryDefeattext.GetComponent<Text>().text = (Win) ? "Victoire" : "Defaite";
        if (Win)
        {
            UiVD.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            TextTimer.GetComponent<Text>().text = "Temps Final : " + Timer.timer.ToString("0.00");
            return;
        }
        if (Bullet.NbBullet == 0)
        {
            Win = false;
            Cursor.lockState = CursorLockMode.None;
            UiVD.SetActive(true);
            return;
        }
        UiVD.SetActive(false);
    }
}
