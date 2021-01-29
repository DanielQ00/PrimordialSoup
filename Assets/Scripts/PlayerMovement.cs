using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attach script to main Player GameObject
public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;

    private float movementSpeed = 5.0f;
    private Vector3 moveDirection;


    // Start is called before the first frame update
    void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
        if (characterController == null)
        {
            characterController = gameObject.AddComponent<CharacterController>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RotatePlayer();
    }
    private void MovePlayer()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

        characterController.Move(moveDirection * Time.deltaTime * movementSpeed);
    }

    private void RotatePlayer()
    { 
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);

        if (groundPlane.Raycast(ray, out float rayLength))
        {
            Vector3 pointToLook = ray.GetPoint(rayLength);

            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }
    }
}
