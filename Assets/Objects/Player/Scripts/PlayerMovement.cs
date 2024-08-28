using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{

    Vector2 movementInput;

    public void OnMove(InputValue value)
    {
        this.movementInput = value.Get<Vector2>();
    }

    void FixedUpdate(){
        move();
    }

    void move(){
        Vector3 movement = new Vector3(movementInput.x, 0, movementInput.y);
        transform.position += movement * Time.fixedDeltaTime;
    }
    
}
