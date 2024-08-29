using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{

    [Header("References")]
        [SerializeField] CharacterController2D controller;
        [SerializeField] Animator animator;
    [Header("Movement")]
        [SerializeField] FloatReference movementSpeed;
    
    
    float horizontalMove;
    bool jump;



    void FixedUpdate(){
        move();
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        
    }

    void move(){
        controller.Move(horizontalMove * movementSpeed.Value * Time.fixedDeltaTime, false, this.jump);
        this.jump = false;
    }

    public void OnLanding(){
        animator.SetBool("IsJumping", false);
        animator.SetBool("IsGround", true);
    }


    public void OnEndJump(){
        animator.SetBool("IsJumping", false) ;
        animator.SetBool("IsGround", false);

    }
    public void OnFalling(){
        animator.SetBool("IsGround", false);
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        this.horizontalMove = context.ReadValue<Vector2>().x;
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed){
            this.jump = true;
        if(animator.GetBool("IsGround"))
            animator.SetBool("IsJumping", true);
            
        }
    }

    
}
