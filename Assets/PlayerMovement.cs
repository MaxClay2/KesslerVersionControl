using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //creates a controller varaible which i added the charcater controller too so the script can be refrenced by 
    //writing controller 
    public CharacterController2D controller;
    public Animator animator;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool jump = false;
    
   
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove)); 

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
       
    }

    public void OnLanding ()
    {
        animator.SetBool("IsJumping", false);
    }



    void FixedUpdate ()
    {
        //Moves the charcter 
        //the first false is false becuase the example im using has a crouching mechanic and i do not

        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }






}
