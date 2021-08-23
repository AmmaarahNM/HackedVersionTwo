using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrypifyManager : MonoBehaviour
{
    public AudioSource[] songs;
    //public bool musicPlaying;
    //AudioSource currentSong;
    public GameObject playButton;
    public GameObject pauseButton;
    //public bool isCurrentPlaying;
    public Text nameDisplayed;

    public GameObject NextBtn;
    public GameObject BackBtn;

    public GameManager GM;


    void Start()
    {
        GM.currentSong = songs[0];
        BackBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        nameDisplayed.text = GM.currentSong.name;
        GM.isCurrentPlaying = GM.currentSong.isPlaying;
        if (!GM.currentSong.isPlaying && GM.musicPlaying)
        {
            for (int i = 0; i < songs.Length; i++)
            {
                if (songs[i] == GM.currentSong)
                {
                    GM.currentSong = songs[i + 1];
                    GM.currentSong.Play();
                    break;
                }
            }
        }

        if (GM.musicPlaying)
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
            GM.musicPlaying = true;
            //playpause icon set to play
            GM.currentSong = song;
        }

        if (song != songs[0])
        {
            BackBtn.SetActive(true);
        }

        else
        {
            BackBtn.SetActive(false);
        }

        if (song != songs[8])
        {
            
            NextBtn.SetActive(true);
        }

        else
        {
            NextBtn.SetActive(false);
        }

    }

    public void PlayAndPause()
    {
        if (GM.musicPlaying)
        {
            pauseButton.SetActive(false);
            playButton.SetActive(true);
            GM.currentSong.Pause();
            GM.musicPlaying = false;
        }

        else
        {
            pauseButton.SetActive(true);
            playButton.SetActive(false);
            GM.currentSong.Play();
            GM.musicPlaying = true;
        }
    }

    public void NextSong()
    {
        BackBtn.SetActive(true);

        for (int i = 0; i < songs.Length; i++)
        {
           
             if (songs[i] == GM.currentSong)
                {
                    foreach (AudioSource songIndex in songs)
                    {
                        songIndex.Stop();
                    }

                     if (songs.Length == i + 2)
                     {
                       NextBtn.SetActive(false);
                     }

                    GM.currentSong = songs[i + 1];
                    GM.currentSong.Play();
                    GM.musicPlaying = true;
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

            if (songs[i] == GM.currentSong)
            {
                foreach (AudioSource songIndex in songs)
                {
                    songIndex.Stop();
                }

                if (i == 1)
                {
                    BackBtn.SetActive(false);
                }

                GM.currentSong = songs[i - 1];
                GM.currentSong.Play();
                GM.musicPlaying = true;
                break;

            }

        }
    }
}
