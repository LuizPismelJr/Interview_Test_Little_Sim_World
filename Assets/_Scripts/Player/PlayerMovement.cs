using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 moving;
    
    [Header("Speed")]
    [SerializeField] float movSpeed;

    Rigidbody2D playerRigidbody2D;

    private void Awake()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        PlayerInputMovement();
    }

    void PlayerInputMovement()
    {
        moving.x = Input.GetAxis("Horizontal");
        moving.y = Input.GetAxis("Vertical");
        moving.z = transform.position.z;
        playerRigidbody2D.velocity = moving * movSpeed * Time.deltaTime;
    }

}
