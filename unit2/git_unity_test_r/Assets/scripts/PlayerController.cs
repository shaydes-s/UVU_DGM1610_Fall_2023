using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.8f;
    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        moveDirection = new Vector3(horizontalInput, moveDirection.y, verticalInput);

        moveDirection = transform.TransformDirection(moveDirection);

        moveDirection.x = moveDirection.x * moveSpeed;
        moveDirection.z = moveDirection.z * moveSpeed;

        controller.Move(moveDirection * Time.deltaTime);

        
        if ((Input.GetButton("Jump") == true) && (controller.isGrounded) && isJumping == false)
        {
            isJumping = true;
            if (isJumping == true)
            {
                moveDirection.y = jumpForce;
                isJumping = false;
            }
        }

        else if (moveDirection.y > -gravity)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        if (moveDirection.y < -gravity)
        {
            moveDirection.y = -gravity;
        }
    }
}
