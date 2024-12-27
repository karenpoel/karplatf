using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBox : MonoBehaviour
{
    public float pushForce = 5f;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if ( collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if ( rb != null )
            {
                float horizontalInput = Input.GetAxis("Horizontal");
                GetComponent<Rigidbody2D>().velocity = new Vector2 (horizontalInput * pushForce, GetComponent<Rigidbody2D>().velocity.y);

               
            }
        }
    }

}
