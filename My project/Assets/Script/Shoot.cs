using System;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public void Update()
    {
        Attack();
    }
    public void Attack()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out var hit) && Input.GetMouseButton(0))
        {
            GameObject CHit = hit.collider.gameObject;
            if (CHit.CompareTag("Cible"))
            {
                CHit.transform.position = new Vector3(-7, 12, 0);
                return;
            }
        }
    }
}