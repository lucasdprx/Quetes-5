using UnityEngine;

public class BoxTeleport : MonoBehaviour
{
    [SerializeField] private int indexTeleport = 0;
    CharacterController characterController;

    private void Start()
    {
        characterController = GameObject.Find("Player").GetComponent<CharacterController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            characterController.enabled = false;
            other.gameObject.GetComponent<Teleport>().TeleportToTransform(indexTeleport);
            characterController.enabled=true;
        }
    }
}
