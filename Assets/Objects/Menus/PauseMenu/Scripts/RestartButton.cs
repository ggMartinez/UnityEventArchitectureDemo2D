using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] PauseMenu pauseMenu;

    public void OnRestart(){
        pauseMenu.OnPause();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
