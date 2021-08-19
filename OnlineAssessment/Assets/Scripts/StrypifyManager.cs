using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrypifyManager : MonoBehaviour
{
    public AudioSource[] songs;
    public bool musicPlaying;
    AudioSource currentSong;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SongClicked(AudioSource song) //buttons with each song title on it set to play that song
    {
        if (!song.isPlaying)
        {
            //stop all songs
            foreach (AudioSource songIndex in songs)
            {
                songIndex.Stop();
            }
            song.Play();
            musicPlaying = true;
            //playpause icon set to play
            currentSong = song;
        }
    }

    public void PlayAndPause()
    {
        if (musicPlaying)
        {
            //change icon to pause
            currentSong.Pause();
            musicPlaying = false;
        }

        else
        {
            //change icon to play
            currentSong.Play();
            musicPlaying = true;
        }
    }

    public void LoopPlaylist()
    {

    }
}
