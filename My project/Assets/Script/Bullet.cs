using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public static int NbBullet = 45;
    [SerializeField] private GameObject BulletText;

    void Update()
    {
        BulletText.GetComponent<Text>().text = NbBullet.ToString();
    }
}
