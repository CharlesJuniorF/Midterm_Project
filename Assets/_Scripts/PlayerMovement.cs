using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Camera cam;

    private Vector2 velocity;
    private float inputAxis;

    public float moveSpeed = 8.0f;
    public float maxJumpHeight = 5f;
    public float maxJumpTime = 1f;

    public float jumpForce => (2.0f * maxJumpHeight) / (maxJumpHeight / 2.0f);
    public float gravity => (-2.0f * maxJumpHeight) / Mathf.Pow((maxJumpTime / 2.0f), 2.0f);

    public bool grounded { get; private set; }
    public bool jumping { get; private set; }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    private void Update()
    {
        HorizontalMovement();  
        
        grounded = rb.RayCast(Vector2.down);

        if (grounded)
        {
            GroundedMovement();
        }

    }

    private void HorizontalMovement()
    {
        inputAxis = Input.GetAxis("Horizontal");
        velocity.x = Mathf.MoveTowards(velocity.x, inputAxis * moveSpeed, moveSpeed * Time.deltaTime);
    }

    private void GroundedMovement()
    {
        velocity.y = Mathf.Max(velocity.y, 0.0f);
        jumping = velocity.y > 0.0f;

        if (Input.GetButtonDown("Jump"))
        {
            velocity.y = jumpForce;
            jumping = true;
        }
    }

    private void ApplyGravity()
    {
        bool falling = velocity.y < 0.0f || !Input.GetButton("Jump");
        float multiplier = falling ? 2.0f : 1f;

        velocity.y += gravity * multiplier * Time.deltaTime;
        velocity.y = Mathf.Max(velocity.y, gravity / 2.0f);
    }

    private void FixedUpdate()
    {
        Vector2 position = rb.position;
        position += velocity * Time.fixedDeltaTime;

        Vector2 leftEdge = cam.ScreenToWorldPoint(Vector2.zero);
        Vector2 rightEdge = cam.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        position.x = Mathf.Clamp(position.x + 0.5f, leftEdge.x, rightEdge.x - 0.5f);

        rb.MovePosition(position);
    }
}
