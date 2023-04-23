using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public float jumpForce = 10.0f;
    Rigidbody2D rb;
    
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.relativeVelocity.y <= 0f) {
            rb = other.gameObject.GetComponent<Rigidbody2D>();
            if (rb) {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
        }
    }
}
