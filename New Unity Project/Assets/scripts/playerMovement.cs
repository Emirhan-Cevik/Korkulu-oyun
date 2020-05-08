using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float jumpHeight = 0.5f;
    public CharacterController PlayerController;
    public float gravity = -9.81f;
    Vector3 velocity;
    public Transform groundController;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundController.position, groundDistance, groundMask);
        if(isGrounded&&velocity.y<0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        PlayerController.Move(move * moveSpeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.LeftShift))
        {
            PlayerController.Move(move * moveSpeed*2 * Time.deltaTime);
        }
        velocity.y += gravity * Time.deltaTime;
        PlayerController.Move(velocity * Time.deltaTime);
        if(isGrounded&&Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

    }
}
