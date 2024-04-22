using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] songs;
    private AudioSource audioSource;
    private int currentSongIndex = 0;

    public float Tiempo;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayNextSong();

    }

    // Update is called once per frame
    public void PlayNextSong()
    {
        if (currentSongIndex < songs.Length)
        {
            audioSource.clip = songs[currentSongIndex];
            audioSource.Play();
            currentSongIndex++;
        }
        else
        {
            currentSongIndex = 0; 
            PlayNextSong();
        }
    }

    private void Update()
    {
        Tiempo = Time.time;
    }
}
