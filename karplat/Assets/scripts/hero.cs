using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour  {
    public float speed;
    private Animator anim;
 Rigidbody2D rb;
 Prived void Update()

 void Start () {
    rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
     }

    private States State
    {
        get { return (States)anim.GetInteger("state"); }
        set { anim.SetInteger("state",(int)value); }
            
            
    }
     
    void FixedUpdate () {
        float x = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(x * speed, rb.velocity.y, 0f);
        rb.velocity = move;
        }
        

    
    
           
           

    

    
      
       
       
        
    
}

public enum States
{
    idle,
    run,
    jump
}