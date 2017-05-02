using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 6f;
<<<<<<< HEAD
<<<<<<< HEAD
    CharacterController characterController;
    public float jumpSpeed = 600f;
    private float gravity = 5f;
    private float jumpforce = 10f;
=======
    public float jumpSpeed = 6f;
    public Camera cam;
    public Transform camTransform;
    float f;

    bool isGrounded;
>>>>>>> origin/master
=======
    public float jumpSpeed = 6f;
>>>>>>> parent of 43c4c16... #2 BallMovement

    private Vector3 movement;
    Rigidbody playerRigidbody;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
<<<<<<< HEAD
<<<<<<< HEAD
        characterController = GetComponent<CharacterController>();
=======
        cam = Camera.main;
        camTransform = cam.transform;

>>>>>>> origin/master
=======
>>>>>>> parent of 43c4c16... #2 BallMovement
    }

    void FixedUpdate ()
    {

<<<<<<< HEAD
<<<<<<< HEAD
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

=======
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Move(h, 0, v);
>>>>>>> origin/master
=======
      
        Move(h, v,0);
>>>>>>> parent of 43c4c16... #2 BallMovement
    }

    void Move(float h, float j, float v)
    {
        movement = new Vector3(h, 0, v);

        //Rotera boll efter kaverafv
       // Quaternion rotation = Quaternion.Euler(, currentY, 0);

        //movement.normalized();
        playerRigidbody.AddForce(movement * speed);

<<<<<<< HEAD
        playerRigidbody.MovePosition(transform.position + movement);
<<<<<<< HEAD

=======
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerRigidbody.AddForce(0, jumpSpeed, 0);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ground")
        {
            isGrounded = true;
        }
<<<<<<< HEAD
        else
            isGrounded = false;
>>>>>>> origin/master
=======

>>>>>>> origin/master
=======
        if (Input.GetAxisRaw("Jump")>0) 
        {
            playerRigidbody.AddForce(Vector3.up*jumpSpeed);
        }
>>>>>>> parent of 43c4c16... #2 BallMovement
    }
}
