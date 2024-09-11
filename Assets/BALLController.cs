using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;

public class BALLController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    float speed = 10f;
    [SerializeField]
    TMP_Text endGameText;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        endGameText.gameObject.SetActive(false);
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime;
        rb.velocity = move;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "End")
        {
            endGameText.gameObject.SetActive(true);
        }
    }
}