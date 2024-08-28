using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    public string Name;
    [HideInInspector] public AudioSource Source;
    public AudioClip[] Clips;
    [Range(0f, 1f)]public float Volume;
    [Range(-3f, 3f)]public float Pitch = 1;
    public bool Loop = false;
    public bool PlayOnAwake = false;
}

