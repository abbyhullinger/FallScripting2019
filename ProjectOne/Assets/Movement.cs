using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    public float gravity = 3f;
    public float jumpSpeed = 10f;
    
    private Vector3 position;
    public CharacterController controller;
    
    
    void Update()
    {
        
        position.x = speed * Input.GetAxis("Horizontal");
// ! MEANS FALSE, OR IS NOT GROUNDED
        if (!controller.isGrounded)
        {
            position.y -= gravity;
        }
       
        if (Input.GetButtonDown("Jump"))
        {
            position.y = jumpSpeed;
        }
        controller.Move(position*Time.deltaTime);
    }
}
