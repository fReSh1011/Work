using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float runSpeed = 5f;
    public float fastRun;

    public Rigidbody rb;
    public Animator animator;

    public GameObject spell;
    public Transform shotPoint;

    private float timeBtwShots;
    public float startTimeBtwShots;

    public Sprite sprite; 

    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(Vector3.forward);
    }
    void FixedUpdate()
    {
        Move();
        Attack();
    }

    private void Move()
    {
        if (Input.GetKey("d") && Input.GetKey("w"))
        {
            rb.MovePosition(transform.position + new Vector3(0.5f, 0, 0.5f) * (runSpeed + fastRun) * Time.deltaTime);
            animator.SetBool("isRunning", true);
            gameObject.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);

        }
        else if (Input.GetKey("a") && Input.GetKey("w"))
        {
            rb.MovePosition(transform.position + new Vector3(-0.5f, 0, 0.5f) * (runSpeed + fastRun) * Time.deltaTime);
            animator.SetBool("isRunning", true);
            gameObject.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        }
        else if (Input.GetKey("a") && Input.GetKey("s"))
        {
            rb.MovePosition(transform.position + new Vector3(-0.5f, 0, -0.5f) * (runSpeed + fastRun) * Time.deltaTime);
            animator.SetBool("isRunning", true);
            gameObject.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        }
        else if (Input.GetKey("d") && Input.GetKey("s"))
        {
            rb.MovePosition(transform.position + new Vector3(0.5f, 0, -0.5f) * (runSpeed + fastRun) * Time.deltaTime);
            animator.SetBool("isRunning", true);
            gameObject.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
        }
        else if (Input.GetKey("s"))
        {
            rb.MovePosition(transform.position + Vector3.back * (runSpeed + fastRun) * Time.deltaTime);
            animator.SetBool("isRunning", true);
        }
        else if (Input.GetKey("a"))
        {
            rb.MovePosition(transform.position + Vector3.left * (runSpeed + fastRun) * Time.deltaTime);
            animator.SetBool("isRunning", true);
            gameObject.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        }
        else if (Input.GetKey("d"))
        {
            rb.MovePosition(transform.position + Vector3.right * (runSpeed + fastRun) * Time.deltaTime);
            animator.SetBool("isRunning", true);
            gameObject.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
        }
        else if (Input.GetKey("w"))
        {
            rb.MovePosition(transform.position + Vector3.forward * (runSpeed + fastRun) * Time.deltaTime);
            animator.SetBool("isRunning", true);
        }
        else if (Input.GetKey(KeyCode.None))
        {
            animator.SetBool("isRunning", false);
        }

        if (Input.GetKey("left shift"))
        {
            animator.SetBool("isFastRunning", true);
            fastRun = 1f;
        }
        else
        {
            fastRun = 0;
            animator.SetBool("isFastRunning", false);
        }
    }

    private void Attack()
    {
        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                animator.SetBool("isAttack", true);
                Instantiate(spell, shotPoint.position, transform.rotation);
            }
            else
            {
                //animator.SetBool("isAttack", false);
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
        
    }
}
