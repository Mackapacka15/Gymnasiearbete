using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public Collider2D groundBox;
    float isGrounded;
    Rigidbody2D body;

    float move; //-1 to 1
    bool jump; //0 or 1
    void awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
    }
    void Jump()
    {
        if(testGrounded() == true)
        {
            
        }
    }
    bool testGrounded() //Tests if the player is grounded
    {
        RaycastHit2D castDown;
        castDown = Physics2D.Raycast(transform.position, Vector2.down, 1, LayerMask.NameToLayer("Ground"));
        Debug.DrawRay(transform.position, Vector2.down);
        return(false);
    }
}