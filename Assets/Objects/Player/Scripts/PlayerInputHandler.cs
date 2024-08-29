using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    // reference PlayerInput component 
    [SerializeField] PlayerInput input;


    public void ToggleInput(bool status){
        input.enabled = status;
    }

}
