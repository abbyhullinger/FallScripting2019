using UnityEngine;
using UnityEngine.XR.WSA;

//this is the rewritten version of the Movement script for practice.
//In this code, it will find the character controller on start
[RequireComponent(typeof(CharacterController))]
public class MovementAgain : MonoBehaviour
{
    private Vector3 position;
    private CharacterController controller;
    private int jumpCount;
    
    public float moveSpeed = 10f, gravity = 9.81f, jumpSpeed = 30f;
    public int jumpCountMax = 2;
    public ParticleSystem particles;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        position.x = moveSpeed*Input.GetAxis("Horizontal");
        position.y -= gravity;

        if (controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump")&& jumpCount < jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount++;
            particles.Emit(100);
            
        }
        controller.Move(position*Time.deltaTime);

       

        
      
    }
}
