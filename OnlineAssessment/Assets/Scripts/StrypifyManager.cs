using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrypifyManager : MonoBehaviour
{
    public AudioSource[] songs;
    public bool musicPlaying;
    AudioSource currentSong;
    public GameObject playButton;
    public GameObject pauseButton;
    public bool isCurrentPlaying;
    public Text nameDisplayed;
    // Start is called before the first frame update
    void Start()
    {
        currentSong = songs[0];
    }

    // Update is called once per frame
    void Update()
    {
        nameDisplayed.text = currentSong.name;
        isCurrentPlaying = currentSong.isPlaying;
        if (!currentSong.isPlaying && musicPlaying)
        {
            for (int i = 0; i < songs.Length; i++)
            {
                if (songs[i] == currentSong)
                {
                    currentSong = songs[i + 1];
                    currentSong.Play();
                    break;
                }
            }
        }

    }

    public void SongClicked(AudioSource song) //buttons with each song title on it set to play that song
    {
        Debug.Log(song.name);
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
            pauseButton.SetActive(false);
            playButton.SetActive(true);
            currentSong.Pause();
            musicPlaying = false;
        }

        else
        {
            pauseButton.SetActive(true);
            playButton.SetActive(false);
            currentSong.Play();
            musicPlaying = true;
        }
    }

    public void NextSong()
    {
        for (int i = 0; i < songs.Length; i++)
        {
            if (songs[i] == currentSong)
            {
                foreach (AudioSource songIndex in songs)
                {
                    songIndex.Stop();
                }
                currentSong = songs[i + 1];
                currentSong.Play();
                musicPlaying = true;
                break;
            }
        }
    }
}
