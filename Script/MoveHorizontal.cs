using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
//using System.Threading;
using UnityEngine;
//using UnityEngine.UI;

public class MoveHorizontal : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private Rigidbody2D rigidBody;
    private float movement;
    public float jumpSpeed = 5f;
    private bool isTouchGround;

    public void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        isTouchGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        Jump();
        if (Input.GetButton("Horizontal"))
        {
            movement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
            Movehorizontal();
        }

        if (Input.GetKeyDown("escape"))
        {
            // turn on the cursor
            Cursor.lockState = CursorLockMode.None;

        }
    }

    public void Movehorizontal()
    {
        transform.Translate(movement, 0, 0);
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isTouchGround == true)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
        }
    }
    
  

}
