using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float timer;
    void Update()
    {
        GetComponent<Text>().text = "Time : " + timer.ToString("0.00");
        if (Bullet.NbBullet == 0 || VictoryDefeat.Win)
            return;
        timer += Time.deltaTime;
    }
}
