using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioToggle : MonoBehaviour
{
    public Toggle musicToggle;
    public AudioClip musicClip;

    private AudioSource musicAudio;

    private bool isMusicOn = true;

    // Start is called before the first frame update
    void Start()
    {
        // Get the audio source component
        musicAudio = GetComponent<AudioSource>();

        // Set the toggle to the initial music state
        musicToggle.isOn = isMusicOn;

        // Set the initial music state
        if (isMusicOn)
        {
            musicAudio.clip = musicClip;
            musicAudio.Play();
        }
        else
        {
            musicAudio.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the toggle has been changed
        if (musicToggle.isOn != isMusicOn)
        {
            // Toggle the music on/off
            isMusicOn = musicToggle.isOn;

            if (isMusicOn)
            {
                musicAudio.clip = musicClip;
                musicAudio.Play();
            }
            else
            {
                musicAudio.Stop();
            }
        }
    }

    // Turn the music audio clip on
    public void TurnOnMusic()
    {
        isMusicOn = true;

        if (musicAudio != null && musicAudio.clip == null)
        {
            musicAudio.clip = musicClip;
        }

        if (musicAudio != null && !musicAudio.isPlaying)
        {
            musicAudio.Play();
        }
    }
}
