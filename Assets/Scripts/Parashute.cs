using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parashute : MonoBehaviour
{
    public LayerMask groundLayer;
    public bool isGrounded;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1, groundLayer);
        if (isGrounded)
        {
            animator.enabled = false;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            animator.enabled = false;

    }
}
