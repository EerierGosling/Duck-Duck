using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float acceleration;
    public float deceleration;
    public float jumpForce;
    public int maxJumps = 2;
    private int jumpCount = 0;

    private bool isGrounded;
    private Rigidbody2D rb;
    private float moveInput;
    private float currentVelocity;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask ground;

    public bool facingRight;

    private bool isMoving = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, ground);

        if (isGrounded)
        {
            jumpCount = 0;
        }

        moveInput = Input.GetAxisRaw("Horizontal");

        if (moveInput != 0 && !isMoving)
        {
            isMoving = true;
          
        }
        else if (moveInput == 0 && isMoving)
        {
            isMoving = false;
           
        }

        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || jumpCount < maxJumps))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpCount++;
        }

        if (moveInput > 0 && !facingRight) 
        {
            Flip();
        }
        else if (moveInput < 0 && facingRight) 
        {
            Flip();
        }
    }

    void FixedUpdate()
    {
        float targetVelocity = moveInput * speed;

        if (moveInput != 0)
        {
            currentVelocity = Mathf.MoveTowards(currentVelocity, targetVelocity, acceleration * Time.fixedDeltaTime);
        }
        else
        {
            currentVelocity = Mathf.MoveTowards(currentVelocity, 0f, deceleration * Time.fixedDeltaTime);
        }

        rb.velocity = new Vector2(currentVelocity, rb.velocity.y);
    }

    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 newScale = transform.localScale;
        newScale.x *= -1;
        transform.localScale = newScale;
    }
}
