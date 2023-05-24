using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 13f;
    public float gravity = -9.81f;
    public float stairStepHeight = 0.2f;

    private bool isOnStairs = false;
    private Vector3 moveDirection;

    void Update()
    {
        if (isOnStairs)
        {
            HandleStairsMovement();
        }
        else
        {
            HandleRegularMovement();
        }
    }

    void HandleRegularMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        moveDirection.y += gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    void HandleStairsMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        moveDirection = move * speed;

        if (move.magnitude > 0)
        {
            float stepHeight = stairStepHeight * Time.deltaTime;
            moveDirection.y = Mathf.Max(moveDirection.y, stepHeight);
        }
        else
        {
            moveDirection.y = 0f;
        }

        controller.Move(moveDirection * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Stairs"))
        {
            isOnStairs = true;
            moveDirection = Vector3.zero;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Stairs"))
        {
            isOnStairs = false;
            moveDirection = Vector3.zero;
        }
    }
}
