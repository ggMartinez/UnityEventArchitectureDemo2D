using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPause : MonoBehaviour
{

    [SerializeField] GameEvent pauseEvent;

    public void OnPause(){
        pauseEvent.Raise();
    }
}
