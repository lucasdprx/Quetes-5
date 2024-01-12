using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvTarget : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private bool wave;

    void Update()
    {

        if (transform.position.x > 13)
        {
            Speed = -Speed;
            transform.position = new Vector3(13,transform.position.y,transform.position.z);
        }
        if (transform.position.x < -5.5)
        {
            Speed = -Speed;
            transform.position = new Vector3((float)-5.5, transform.position.y, transform.position.z);
        }
        if (transform.position.y > 10)
        {
            Speed = -Speed;
            transform.position = new Vector3(transform.position.x, 10, transform.position.z);
        }
        if (transform.position.y < 2)
        {
            Speed = -Speed;
            transform.position = new Vector3(transform.position.x, 2, transform.position.z);
        }

        if (wave)
            transform.position += new Vector3(Speed * Time.deltaTime, 0, 0);
        if (!wave)
            transform.position += new Vector3(0, Speed * Time.deltaTime, 0);
    }
}
