using UnityEngine;
using UnityEngine.XR.WSA;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    private Vector3 position;
    private CharacterController controller;
    private int jumpCount;
    
    public float moveSpeed = 25f, gravity = 0.001f, jumpSpeed = 30f;
    public int jumpCountMax = 5;
    public ParticleSystem particles;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        position.x = moveSpeed*Input.GetAxis("Horizontal");
        position.z = moveSpeed * Input.GetAxis("Vertical");
        position.y -= gravity;
//delete position z for other scene if you want;
        if (controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump")&& jumpCount < jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount++;
            
        }
        controller.Move(position*Time.deltaTime);

       

        
      
    }
}
