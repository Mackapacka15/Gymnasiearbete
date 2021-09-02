using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControlls : MonoBehaviour
{
    public float move; //-1 to 1
    public bool jump; //0 or 1
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ActivateJump()
    {
        jump = true;
    }
    public void DeactivateJump()
    {
        jump = false;
    }
    public void MoveLeft()
    {
        move = -1;
    }
    public void MoveRight()
    {
        move = 1;
    }
    public void StopMoving()
    {
        move = 0;
    }
}
