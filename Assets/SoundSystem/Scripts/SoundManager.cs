using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup mixer;
    [SerializeField] Sound[] sounds;

    public static SoundManager instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        foreach (Sound s in sounds)
        {
            s.Source = gameObject.AddComponent<AudioSource>();
            s.Source.clip = s.Clips[Random.Range(0, s.Clips.Length)];
            s.Source.outputAudioMixerGroup = mixer;
            s.Source.volume = s.Volume;
            s.Source.loop = s.Loop;
            if (s.PlayOnAwake)
                s.Source.Play();
        }
    }

    public void PlaySound(string name)
    {
        foreach (Sound s in sounds)
        {
            if (s.Name.Equals(name) && s.Source != null)
            {
                s.Source.clip = s.Clips[Random.Range(0, s.Clips.Length)];
                s.Source.Play();
            }
        }
    }

    void PauseSound(string name)
    {
        foreach (Sound s in sounds)
        {
            if (s.Name.Equals(name) && s.Source.isPlaying)
                s.Source.Pause();
        }
    }

    public void StopSound(string name)
    {
        foreach (Sound s in sounds)
        {
            if (s.Name.Equals(name) && s.Source.isPlaying)
                s.Source.Stop();
        }
    }

    public void StopAllSounds()
    {
        foreach (Sound s in sounds)
            s.Source.Stop();
    }

    public void SwitchMusic(string clip){
        StopAllSounds();
        PlaySound(clip);
    }


   
}