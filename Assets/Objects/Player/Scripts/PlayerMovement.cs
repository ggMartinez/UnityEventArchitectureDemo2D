using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{

    [SerializeField] CharacterController2D controller;
    [Header("Movement")]
        [SerializeField] FloatReference movementSpeed;
    
    
    float horizontalMove;
    bool jump;

    public void OnMove(InputAction.CallbackContext context)
    {
        this.horizontalMove = context.ReadValue<Vector2>().x;
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed){
            this.jump = true;
        }
    }

    void FixedUpdate(){
        move();
        
    }

    void move(){
        controller.Move(horizontalMove * movementSpeed.Value * Time.fixedDeltaTime, false, this.jump);
        this.jump = false;
    }


    
}
