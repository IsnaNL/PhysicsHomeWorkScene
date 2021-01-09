using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveForceForSpring : MonoBehaviour
{
    Rigidbody2D rb;

    public float force;
  // public float timeBetweenForceDown;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
   void FixedUpdate()
    {
        if(rb.velocity.y < 0)
        {
            rb.AddForce(Vector2.down * force);
        }
        
    }
   
     
}
