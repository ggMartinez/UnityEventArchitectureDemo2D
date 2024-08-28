using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuButton : MonoBehaviour
{
    [SerializeField] PauseMenu pauseMenu;
    public void OnMenu(){
        pauseMenu.OnPause();
        SceneManager.LoadScene("MainMenu");
    }
}
