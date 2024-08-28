using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{

    public void OnMove(InputValue value)
    {
        // move the player based on the input value

        Vector2 inputVector = value.Get<Vector2>();
        Vector3 movement = new Vector3(inputVector.x, 0, inputVector.y);
        transform.position += movement * Time.deltaTime;


    }

    public void OnJump(InputValue value)
    {
        
    }
}
