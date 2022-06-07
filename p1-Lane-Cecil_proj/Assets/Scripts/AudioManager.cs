using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public float masterVolume;
    [SerializeField] AudioListener al;
    [SerializeField] Slider volumeSlider;
    public Sound[] sounds;
    public Menu effectsOn;

    // Start is called before the first frame update
    void Awake()
    {
        al = GetComponent<AudioListener>();
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found.");
            return;

        }

        if (effectsOn.VFX)
        {
            s.source.Play(); 
        }
        else
        {
            Play("Game Music"); 
        }
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found.");
            return;

        }
        s.source.Stop();
    }

    public void Pause(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found.");
            return;

        }
        s.source.Pause();
    }
}
