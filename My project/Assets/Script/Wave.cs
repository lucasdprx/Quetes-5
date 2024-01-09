using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public static int nbWave = 1;
    List<GameObject> waves = new List<GameObject>();
    public GameObject wave1;
    public GameObject wave2;
    public GameObject wave3;
    public GameObject wave4;
    public GameObject wave5;

    void Update()
    {
        UpdateWave();
        foreach(Transform t in transform)
        {
            waves.Add(t.gameObject);
        }
        //print(waves[-1].name);
    }

    private void UpdateWave()
    {
        switch (nbWave)
        {
            case 1:
                wave1.SetActive(true); break;
            case 2:
                wave2.SetActive(true);
                wave1.SetActive(false); break;
            case 3:
                wave3.SetActive(true);
                wave2.SetActive(false); break;
            case 4:
                wave4.SetActive(true);
                wave3.SetActive(false); break;
            case 5:
                wave5.SetActive(true);
                wave4.SetActive(false); break;

        }
        switch (Score.score)
        {
            case 25: 
                nbWave = 2;
                Bullet.NbBullet = 4500;
                Score.scoreMax = 50; break;
            case 50:
                nbWave = 3;
                Bullet.NbBullet = 4000;
                Score.scoreMax = 75; break;
            case 75:
                nbWave = 4;
                Bullet.NbBullet = 3500;
                Score.scoreMax = 100; break;
            case 100: 
                nbWave = 5;
                Bullet.NbBullet = 3000;
                Score.scoreMax = 125; break;
        }

    }
}
