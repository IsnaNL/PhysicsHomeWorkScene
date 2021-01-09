using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 velocity;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        if (transform.CompareTag("Parachute"))
        {
            velocity = Vector2.down;
        }
        else
        {
            velocity = Vector2.up;
        }
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(velocity * force);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Parachute"))
        {
            Destroy(collision.gameObject);
           
        }
        Destroy(this.gameObject);
    }
}
