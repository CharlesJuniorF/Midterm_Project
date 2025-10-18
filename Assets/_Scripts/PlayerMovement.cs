using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 2.0f;
    public BoxCollider2D groundCollider;

    public Vector2 standingSize;
    public Vector2 crouchSize;

    public bool hasMushroom = false;

    private Rigidbody2D rb;
    private const float gravity = 1.8f;

    // Improvements to consider:
    // - Double jump
    // - Easing into movement (accelerating more slowly)

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = gravity;
    }

    // Update is called once per frame
    void Update()
    {
        if (hasMushroom)
        {
            transform.localScale = new Vector3(1f, 0.5f, 1f);

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                speed = 0.0f;
                transform.localScale = new Vector3(1f, 0.5f, 1f);
            }
            else
            {
                speed = 5.0f;
                transform.localScale = new Vector3(1f, 1f, 1f);
            }

        }
        else
        {
            transform.localScale = new Vector3(1f, 0.5f, 1f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position += speed * Time.deltaTime * Vector3.left;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position += speed * Time.deltaTime * Vector3.right;
        }

        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.RightControl) ||  Input.GetKey(KeyCode.LeftControl))
        {
            speed = 18.0f;
        }
        else
        {
            speed = 9.0f;
        }
    }

    private bool IsGrounded()
    {
         return groundCollider.IsTouchingLayers(LayerMask.GetMask("Ground"));
    }
}
