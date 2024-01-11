using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Windows;

public class Shoot : MonoBehaviour
{
    private static readonly System.Random random = new System.Random();
    private System.Random rnd = random;
    public Transform rectTransform;
    private int resX;
    private int resY;
    private float resZ;
    private int timer;
    public new Camera camera;
    public void Update()
    {
        Attack();
    }
    public void Attack()
    {
        if (UnityEngine.Input.GetMouseButtonDown(0) && Bullet.NbBullet != 0 && !GamePaused.gameIsPaused)
        {
            Bullet.NbBullet -= 1;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out var hit))
            {
                GameObject CHit = hit.collider.gameObject;
                if (CHit.CompareTag("Cible"))
                {
                    if (timer == 0)
                    {
                        rectTransform = CHit.GetComponent<Transform>();
                        resX = rnd.Next(-7, 12);
                        resY = rnd.Next(2, 10);
                        resZ = rectTransform.position.z;
                        rectTransform.position = new Vector3(resX, resY, resZ);
                        //timer += 1;
                        Score.score += 1;
                    }
                }
                if (CHit.CompareTag("William"))
                {
                    Destroy(CHit);
                    Bullet.NbBullet += 11;
                }
                if (CHit.CompareTag("CibleWin"))
                {
                    Destroy(CHit);
                    VictoryDefeat.Win = true;
                }
            }
        }
        if (timer != 0)
        {
            timer += 1;
        }
        if (timer == 20)
        {
            timer = 0;
        }
    }
}