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
    bool canMove = true;
    bool attacking = false;


    void Start(){
        this.canMove = true;
        this.attacking = false;
    }
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
        if(canMove){
            if(context.ReadValue<Vector2>().x > 0) this.horizontalMove = 1;
            if(context.ReadValue<Vector2>().x < 0) this.horizontalMove = -1;
            if(context.ReadValue<Vector2>().x == 0) this.horizontalMove = 0;
        }
        if(!canMove)
            this.horizontalMove = 0;
        
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed){
            if(canMove){
                this.jump = true;
            
            if(animator.GetBool("IsGround"))
                animator.SetBool("IsJumping", true);
                
            }
        }
    }

    public void OnAttack(InputAction.CallbackContext context){
        if(context.performed && !this.attacking){
            this.canMove = false;
            this.animator.SetBool("IsJumping", false);
            this.animator.SetBool("IsAttacking", true);
            this.attacking = true;
        }
    }

    public void OnAttackEnd(){
        this.canMove = true;
        this.attacking = false;
        this.animator.SetBool("IsAttacking", false);

    }

    
}
