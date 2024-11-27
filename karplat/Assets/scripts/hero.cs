using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour  {
    public float speed;

Rigidbody2D rb;

void Start () {
    rb = GetComponent<Rigidbody2D>();
     }


    void FixedUpdate () {
        float x = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(x * speed, rb.velocity.y, 0f);
        rb.velocity = move;
        }
        

    
    
           
           

    

    
      
       
       
        
    
}

