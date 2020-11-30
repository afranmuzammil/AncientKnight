using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class playerMove : MonoBehaviour
{
    public CharcterController Controller;
    public float speed = 40f;

    public float moveHorizontal=0f;
    public bool jump = false;
    public Animator animator;
    public bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal")*speed;

        moveHorizontal = CrossPlatformInputManager.GetAxis("Horizontal")*speed;// mobile
        if (moveHorizontal != 0)
        {
            animator.SetBool("walk", true);
        }
        else
        {
            animator.SetBool("walk", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetTrigger("jump");
        }
        //mobile
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetTrigger("jump");
        }
        
        if (Input.GetButtonDown("crouch"))
        {
            crouch = true;
            animator.SetBool("crouch", true);
        }
        else if(Input.GetButtonUp("crouch"))
        {
            crouch = false;
            animator.SetBool("crouch", false);
        }
        //mobile
        if (CrossPlatformInputManager.GetButtonDown("crouch"))
        {
            crouch = true;
            animator.SetBool("crouch", true);
        }
        else 
        {
            crouch = false;
            animator.SetBool("crouch", false);
        }



    }
    
    private void FixedUpdate()
    {
        Controller.Move(moveHorizontal*Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
    public void Move()
    {
        Debug.Log("pressed");
        moveHorizontal = Input.GetAxisRaw("Horizontal") * speed;
        Debug.Log(moveHorizontal);
    }
}
