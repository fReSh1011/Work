using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float fastRun;
    public float speed = 5f;
    public Animator animator;
    private Vector2 direction;
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
        Animation();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * (speed + fastRun) * Time.fixedDeltaTime);
    }

    private void Move()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKey("left shift"))
            fastRun = 2f;
        else
            fastRun = 0;
    }

    private void Animation()
    {
        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Speed", (direction.sqrMagnitude + fastRun));                
    }
}
