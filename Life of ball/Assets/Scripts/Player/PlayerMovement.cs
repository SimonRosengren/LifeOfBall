using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 6f;
    public float jumpSpeed = 6f;

    private Vector3 movement;
    Rigidbody playerRigidbody;
    float f;

    void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

      
        Move(h, v,0);
    }

    void Move(float h, float v, float j)
    {
        movement.Set(h, j, v);
        movement = movement.normalized * speed * Time.deltaTime;

        playerRigidbody.MovePosition(transform.position + movement);
        if (Input.GetAxisRaw("Jump")>0) 
        {
            playerRigidbody.AddForce(Vector3.up*jumpSpeed);
        }
    }
}
