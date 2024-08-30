using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelIntro : MonoBehaviour
{
    [SerializeField] GameEventBool playerCanMove;
    [SerializeField] GameObject levelIntroCanvas;

    [Header("Level Number")]
        [SerializeField] TMP_Text levelNumberObject;
        [SerializeField] string levelNumberText;
    
    [Header("Level Name")]
        [SerializeField] TMP_Text levelNameObject;
        [SerializeField] string levelNameText;

    
    void Start()
    {
        levelNumberObject.text = levelNumberText + ":";
        levelNameObject.text = levelNameText;
        playerCanMove.Raise(false);
    }

    public void EndAnimation(int value)
    {
        playerCanMove.Raise(System.Convert.ToBoolean(value));
        levelIntroCanvas.SetActive(false);
    }
}
