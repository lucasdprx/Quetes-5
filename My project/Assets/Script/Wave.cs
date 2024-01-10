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
            case 25: 
                nbWave = 2;
                if (Score.scoreMax == 50)
                    return;
                Bullet.NbBullet = 45;
                Score.scoreMax = 50; break;
            case 50:
                nbWave = 3;
                if (Score.scoreMax == 75)
                    return;
                Bullet.NbBullet = 45;
                Score.scoreMax = 75; break;
            case 75:
                nbWave = 4;
                if (Score.scoreMax == 100)
                    return;
                Bullet.NbBullet = 40;
                Score.scoreMax = 100; break;
            case 100: 
                nbWave = 5;
                if (Score.scoreMax == 125)
                    return;
                Bullet.NbBullet = 35;
                Score.scoreMax = 125; break;
            case 125:
                nbWave = 6; break;
        }

    }
}
