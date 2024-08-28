using UnityEngine;
using UnityEngine.Audio;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup mixer;
    [SerializeField] Sound[] sounds;

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
}
