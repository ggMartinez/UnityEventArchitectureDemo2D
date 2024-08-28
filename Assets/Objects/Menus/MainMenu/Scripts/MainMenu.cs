using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject menuCanvas;
    [SerializeField] GameObject creditsCanvas;
    [SerializeField] GameObject playButton;
    [SerializeField] GameObject backButton;
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuiGame(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }

    public void ShowCredits(){
        menuCanvas.SetActive(false);
        creditsCanvas.SetActive(true);
        EventSystem.current.SetSelectedGameObject(backButton);
    }

    public void HideCredits(){
        menuCanvas.SetActive(true);
        creditsCanvas.SetActive(false);
        EventSystem.current.SetSelectedGameObject(playButton);
    }
}
