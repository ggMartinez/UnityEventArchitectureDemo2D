using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : MonoBehaviour
{
    [SerializeField] PauseMenu pauseMenu;

    public void OnResume(){
        pauseMenu.OnPause();
    }
}
