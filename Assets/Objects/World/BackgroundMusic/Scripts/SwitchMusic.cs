using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusic : MonoBehaviour
{
    [SerializeField] GameEventString playMusic;
    [SerializeField] string musicName;

    void Start(){
        playMusic.Raise(musicName);
    }
}
