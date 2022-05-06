using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    // Start is called before the first frame update
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }


    void OnMove(InputValue movementValue)
    {
        // gets vector2 value from the movement data and stores it in a vector2 variable called "movementVector"
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement*speed);

    }

}
