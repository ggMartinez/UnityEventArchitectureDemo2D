using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] SoundManager soundManager;

    public void PlayClip(string clip){
        soundManager.StopAllSounds();
        soundManager.PlaySound(clip);
    }
}
