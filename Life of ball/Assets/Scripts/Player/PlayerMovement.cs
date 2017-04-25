using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 6f;
    public float jumpSpeed = 6f;

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

        movement = new Vector3(h, 0, v);
        playerRigidbody.AddForce(movement * speed);

        if (Input.GetAxis("Jump") > 0)
        {
            playerRigidbody.AddForce(Vector3.up * jumpSpeed);
        }

        // Move(h, 0, v);
    }

    //void Move(float h, float j, float v)
    //{
    //    movement.Set(h, j, v);
    //    //movement = movement.normalized * speed * Time.deltaTime;


    //    //playerRigidbody.MovePosition(transform.position + movement);


    //    if (Input.GetAxisRaw("Jump") > 0)
    //    {
    //        playerRigidbody.AddForce(Vector3.up * jumpSpeed);
    //    }
    //}
}
