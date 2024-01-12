using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public static int nbWave = 1;
    public GameObject wave1;
    public GameObject wave2;
    public GameObject wave3;
    public GameObject wave4;
    public GameObject wave5;

    public const float inf = Mathf.Infinity;

    void Update()
    {
        UpdateWave();
    }

    private void UpdateWave()
    {
        switch (nbWave)
        {
            case 2:
                wave1.SetActive(false); break;
            case 3:
                wave2.SetActive(false); break;
            case 4:
                wave3.SetActive(false); break;
            case 5:
                wave4.SetActive(false); break;
            case 6: 
                wave5.SetActive(false); break;

        }
        switch (Score.score)
        {
            case 15: 
                nbWave = 2;
                if (Score.scoreMax == 30)
                    return;
                Bullet.NbBullet = 30;
                Score.scoreMax = 30; break;
            case 30:
                nbWave = 3;
                if (Score.scoreMax == 45)
                    return;
                Bullet.NbBullet = 30;
                Score.scoreMax = 45; break;
            case 45:
                nbWave = 4;
                if (Score.scoreMax == 60)
                    return;
                Bullet.NbBullet = 30;
                Score.scoreMax = 60; break;
            case 60: 
                nbWave = 5;
                if (Score.scoreMax == 75)
                    return;
                Bullet.NbBullet = 25;
                Score.scoreMax = 75; break;
            case 75:
                nbWave = 6; break;
        }

    }
}
