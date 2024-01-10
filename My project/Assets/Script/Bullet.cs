using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public static int NbBullet = 45;
    [SerializeField] private GameObject BulletText;
    public GameObject inf;

    void Update()
    {
        if (Wave.nbWave == 6)
        {
            inf.SetActive(true);
            NbBullet = 999999999;
            BulletText.GetComponent<Text>().text = "";
            return;
        }
        BulletText.GetComponent<Text>().text = NbBullet.ToString();
    }
}
