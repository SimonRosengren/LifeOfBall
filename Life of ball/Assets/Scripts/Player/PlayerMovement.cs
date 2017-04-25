using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 6f;
    public float jumpSpeed = 6f;

    bool isGrounded;

    private Vector3 movement;
    Rigidbody playerRigidbody;

    float f;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
       
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Move(h, 0, v);
    }

    void Move(float h, float j, float v)
    {
        movement = new Vector3(h, 0, v);
        playerRigidbody.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerRigidbody.AddForce(0, jumpSpeed, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ground")
        {
            isGrounded = true;
        }
        else
            isGrounded = false;
    }
}
