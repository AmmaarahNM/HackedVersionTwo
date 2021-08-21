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

    public GameObject NextBtn;
    public GameObject BackBtn;


    void Start()
    {
        currentSong = songs[0];
        BackBtn.SetActive(false);
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

        if (musicPlaying)
        {
            pauseButton.SetActive(true);
            playButton.SetActive(false);
        }
        else
        {
            pauseButton.SetActive(false);
            playButton.SetActive(true);
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
        BackBtn.SetActive(true);

        for (int i = 0; i < songs.Length; i++)
        {
           
             if (songs[i] == currentSong)
                {
                    foreach (AudioSource songIndex in songs)
                    {
                        songIndex.Stop();
                    }

                     if (songs.Length == i + 2)
                     {
                       NextBtn.SetActive(false);
                     }

                    currentSong = songs[i + 1];
                    currentSong.Play();
                    musicPlaying = true;
                    break;

             }
            
        }
    }

    public void BackSong()
    {
        NextBtn.SetActive(true);

        Debug.Log("outside");
        for (int i = 0; i < songs.Length; i++)
        {
            Debug.Log("inside");

            if (songs[i] == currentSong)
            {
                foreach (AudioSource songIndex in songs)
                {
                    songIndex.Stop();
                }

                if (i == 1)
                {
                    BackBtn.SetActive(false);
                }

                currentSong = songs[i - 1];
                currentSong.Play();
                musicPlaying = true;
                break;

            }

        }
    }
}
