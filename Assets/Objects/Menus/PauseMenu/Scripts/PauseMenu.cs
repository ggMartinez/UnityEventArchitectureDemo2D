using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    
    [SerializeField] GameObject pauseMenu;
    bool isPaused = false;


    public void OnPause(){
        if(isPaused){
            Time.timeScale = 1;
            isPaused = false;
            pauseMenu.SetActive(false);
        }else{
            Time.timeScale = 0;
            isPaused = true;
            pauseMenu.SetActive(true);
        }
    }

    


}
