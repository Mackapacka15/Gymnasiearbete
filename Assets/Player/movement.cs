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

    float move = 1f; //-1 to 1

    bool jump = true; //0 or 1
    void awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        isGrounded = cast(Vector2.down, true);
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
        bool stopMove = true;
        if(move > 0)
        {
            stopMove = cast(Vector2.right, true);
            Debug.Log("here" + stopMove);
        }
        else if(move < 0)
        {
            stopMove = cast(Vector2.left, true);
        }
        if(stopMove == false)
        {
            velocity.x = runSpeed * Time.deltaTime * move;
        }
        else
        {
            velocity.x = 0;
        }
    }
    bool cast(Vector2 direction, bool show)
    {
        RaycastHit2D castHit;
        castHit = Physics2D.Raycast(transform.position, direction, groundOffset);
        if(show == true)
        {
            Debug.DrawRay(transform.position, direction * groundOffset, Color.red, 1000);  //Shows the ray
        }
        return((bool)castHit);
    }
    
}