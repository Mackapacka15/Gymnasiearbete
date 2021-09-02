using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Collider2D groundBox;
    public float gravity;
    public float groundOffset;

    public float jumpSpeed;
    public float runSpeed;

    Vector2 velocity;
    bool isGrounded;
    Rigidbody2D body;


    float move = 1; //-1 to 1
    bool jump = true; //0 or 1
    void awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        isGrounded = testGrounded();
        
    }
    void FixedUpdate()
    {

        Move();
        if(isGrounded == false)
        {
            velocity.y -= gravity * Time.deltaTime;
        }
        else
        {
            velocity.y = 0;
        }
        if(jump == true && isGrounded == true)
        {
            Jump();

        }
        transform.position += new Vector3(velocity.x, velocity.y, 0);
    }
    void Jump()
    {
        
        velocity.y += jumpSpeed * Time.deltaTime;
    }

    void Move()
    {
        velocity.x = runSpeed * Time.deltaTime * move;
    }
    bool testGrounded() //Tests if the player is grounded
    {
        RaycastHit2D castDown;

        castDown = Physics2D.Raycast(transform.position, Vector2.down * groundOffset, groundOffset);
        //Debug.DrawRay(transform.position, Vector2.down * groundOffset, Color.red, 1000);  //Shows the ray
        //Debug.Log((bool)castDown);
        return((bool)castDown);   //returns true is the player is Grounded
        
    }
    
}