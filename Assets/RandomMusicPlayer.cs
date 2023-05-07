using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMusicPlayer : MonoBehaviour
{
    public AudioClip[] musicClips; // Array of music clips
    public bool playOnAwake = true; // Whether to start playing music on awake
    public bool loop = true; // Whether to loop the music

    private AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        // Get the AudioSource component
        audioSource = GetComponent<AudioSource>();

        // Set the audio clip to play randomly from the musicClips array
        audioSource.clip = musicClips[Random.Range(0, musicClips.Length)];

        // Set the other AudioSource properties
        audioSource.playOnAwake = playOnAwake;
        audioSource.loop = loop;

        // Play the audio clip
        audioSource.Play();
    }
}

