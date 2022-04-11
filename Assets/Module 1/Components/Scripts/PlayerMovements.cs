using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovements : MonoBehaviour
{
    Vector2 directionVector;

    public float speed = .8f;
    Rigidbody body;

    public float jumpForce = 1f;

    public GroundCheck groundCheck;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {

        directionVector = context.ReadValue<Vector2>();
        if (directionVector.x < -0.5f)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (directionVector.x > 0.5f)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (groundCheck.isGrounded && context.performed)
        {
            body.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(0, 0, -directionVector.x).normalized;
        body.MovePosition(transform.position + (movement * speed * Time.deltaTime));

        
    }
}
