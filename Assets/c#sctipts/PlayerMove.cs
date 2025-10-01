using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    
    public float speed=5f;

    public Rigidbody2D rb;
    public float jumpForce = 10f;
        //
        float horizontal;
        public Transform groundCheck;          // Empty GameObject at the player’s feet
        public float groundCheckRadius = 0.2f; // Circle radius for ground detection
        public LayerMask groundLayer;          // Define which layers are "ground"
        private bool isGrounded;
        [SerializeField]
        Animator animator;
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
        animator.SetFloat("yvelocity", Math.Abs(rb.linearVelocity.y));
        animator.SetFloat("xVelocity", Math.Abs(rb.linearVelocity.x));
    }

    public void Move(InputAction.CallbackContext context)
    {  
        horizontal = context.ReadValue<Vector2>().x;
        if (horizontal < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void Jump(InputAction.CallbackContext context)
    {
        
        if (context.performed && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            
        }
    }
}
