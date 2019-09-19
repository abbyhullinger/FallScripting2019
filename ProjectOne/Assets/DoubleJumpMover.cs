using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJumpMover : MonoBehaviour
{
    public float speed = 2f;
    public float gravity = 3f;
    public float jumpSpeed = 10f;
    private int jumpCount = 2;

    private Vector3 position;
    public CharacterController controller; 

    // Update is called once per frame
    void Update()
    {
        position.x = speed * Input.GetAxis("Horizontal");

        if (controller.isGrounded)
        {
            position.y -= gravity;
        }

        if (Input.GetButtonDown("Jump"))
        {
            position.y = jumpSpeed;
        }
        else
        {
            jumpCount = 1;
        }

        if (Input.GetButtonDown("Jump")) 
        {
            position.y = jumpSpeed;
            jumpCount--;
        }
        controller.Move(position * Time.deltaTime);
    }
}
