using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 6f;
    CharacterController characterController;
    public float jumpSpeed = 600f;
    private float gravity = 5f;
    private float jumpforce = 10f;

    private Vector3 movement;
    Rigidbody playerRigidbody;
    float f;

    void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        movement.Set(h, 0, v);
        if (Input.GetButtonDown("Jump"))
        {
            movement.y = jumpSpeed;
        }
        //Move(h, v, jumpSpeed);
        //}
        // Apply gravity

        movement.y -= gravity * Time.deltaTime;

        // Move the controller
        //characterController.Move(movement * Time.deltaTime);

        movement = movement.normalized * speed * Time.deltaTime;

        playerRigidbody.MovePosition(transform.position + movement);

    }

    void Move(float h, float v, float j)
    {
        movement.Set(h, j, v);
        movement = movement.normalized * speed * Time.deltaTime;

        playerRigidbody.MovePosition(transform.position + movement);

    }
}
