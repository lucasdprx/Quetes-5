using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvTarget : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private bool wave;

    void Update()
    {
        if (transform.position.x > 12 || transform.position.x < -7 || transform.position.y > 10 || transform.position.y < 2)
        {
            Speed = -Speed;
        }
        if (wave)
            transform.position += new Vector3(Speed, 0, 0);
        if (!wave)
            transform.position += new Vector3(0, Speed, 0);
    }
}
