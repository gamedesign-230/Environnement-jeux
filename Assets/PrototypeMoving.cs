using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrototypeMoving : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed as needed
    public float rotationSpeed = 5f; // Adjust the rotation speed as needed

    private void Update()
    {
        // Move the camera based on keyboard input
        MoveCamera();

        // Rotate the camera based on mouse input
        RotateCamera();
    }

    private void MoveCamera()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime;

        transform.Translate(movement);
    }

    private void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;

        transform.Rotate(Vector3.up, mouseX);
    }
}
