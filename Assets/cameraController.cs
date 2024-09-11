using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    [SerializeField]
    Vector3 offset;
    [SerializeField]
    Transform player;
    private void Update()
    {
        transform.position = player.position + offset;
        transform.LookAt(player);
    }
}
