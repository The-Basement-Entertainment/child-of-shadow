using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 4.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private CharacterController characterController;
    private Vector3 moveDirection = Vector3.zero;

    // public Vector3 frente = Vector3.zero;
    void Start()
    {
      characterController = GetComponent<CharacterController>();
    }

    void Update()
    {

      if (characterController.isGrounded)
      {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        moveDirection *= moveSpeed;

        if (Input.GetButton("Jump"))
        {
          moveDirection.y = jumpSpeed;
        }
      }

      // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
      // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
      // as an acceleration (ms^-2)
      moveDirection.y -= gravity * Time.deltaTime;

      // Move the controller
      characterController.Move(moveDirection * Time.deltaTime);
    }
}
