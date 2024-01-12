using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Windows;

public class Shoot : MonoBehaviour
{
    private static readonly System.Random random = new System.Random();
    private System.Random rnd = random;
    public Transform rectTransform;
    private int resX;
    private int resY;
    private float resZ;
    public GameObject Laser;
    public GameObject LaserPosition;
    public new Camera camera;
    public int timer = 0;

    public void Start()
    {
        LaserPosition.transform.position = Laser.transform.position;
    }

    public void Update()
    {
        Attack();
        if (timer > 0)
        {
            timer++;
            Laser.transform.position += camera.transform.forward * Time.deltaTime  * 25; 
            if (timer > 20)
            {
                timer = 0;
                Laser.SetActive(false);
                Laser.transform.position = LaserPosition.transform.position;
            }
        }
    }
    public void Attack()
    {
        if (UnityEngine.Input.GetMouseButtonDown(0) && Bullet.NbBullet != 0 && !GamePaused.gameIsPaused && !VictoryDefeat.Win)
        {
            Bullet.NbBullet -= 1;
            timer++;
            Laser.SetActive(true);
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
                    VictoryDefeat.Win = true;
                }
            }
        }
    }
}