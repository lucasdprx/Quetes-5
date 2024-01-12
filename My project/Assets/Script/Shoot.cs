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
    public new Camera camera;
    public void Update()
    {
        Attack();
    }
    public void Attack()
    {
        if (UnityEngine.Input.GetMouseButtonDown(0) && Bullet.NbBullet != 0 && !GamePaused.gameIsPaused && !VictoryDefeat.Win)
        {
            Bullet.NbBullet -= 1;
            AudioManager.instance.PlaySong("Shoot");
            if (Physics.Raycast(camera.transform.position, camera.transform.forward, out var hit, float.PositiveInfinity, ~(1<<LayerMask.NameToLayer("wall") | 1<<LayerMask.NameToLayer("Player"))))
            {
                GameObject CHit = hit.collider.gameObject;
                if (CHit.CompareTag("Cible"))
                {
                    rectTransform = CHit.GetComponent<Transform>();
                    resX = rnd.Next((int)-5.5, 13);
                    resY = rnd.Next(2, 10);
                    resZ = rectTransform.position.z;
                    rectTransform.position = new Vector3(resX, resY, resZ);
                    Score.score += 1;
                }
                if (CHit.CompareTag("William"))
                {
                    Destroy(CHit);
                    Bullet.NbBullet += 11;
                    AudioManager.instance.PlaySong("William");
                }
                if (CHit.CompareTag("CibleWin"))
                {
                    Destroy(CHit);
                    AudioManager.instance.PlaySong("Win");
                    VictoryDefeat.Win = true;
                }
            }
        }
    }
}