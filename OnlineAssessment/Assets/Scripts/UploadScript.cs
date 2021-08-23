using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UploadScript : MonoBehaviour
{
    public GameObject RightFilename;
    public GameObject UniFilename;
    public GameObject FoodFilename;
    public GameObject UploadTab;
    public GameObject error;
    public GameObject reloadScreen;
    public bool rightFileSelected;
    public bool errorUploadActivated;

    public GameObject desktop;

    public bool isUploaded;
    public bool colourGone;
    public GameObject[] colourItems;
    public GameObject[] greyItems;

    public GameObject koreanWelcome;
    public GameObject hackerTerminal;

    public GameController GC;
    public GameObject successfulSub;
    public GameObject timeOver;

    public GameObject[] english;
    public GameObject[] korean;

    public GameObject koreanTitles;
    public GameObject englishTitles;

    public IconPopUps iconPop;

    
    public StrypifyManager colSM;
    public GameManager GM;
    public void openUpload()
    {
        if (isUploaded)
        {
            if (GC.hackerLeft)
            {
                UploadTab.SetActive(true);
            }
            else
            {
                if (!errorUploadActivated)
                {
                    foreach (AudioSource songIndex in colSM.songs)
                    {
                        songIndex.Stop();
                    }
                    GM.musicPlaying = false;

                    Invoke("HackStart", 0f);
                }
                
            }
            
        }
        else
        {
            UploadTab.SetActive(true);
        }
        
        
    }
    public void Rightfile()
    {
        RightFilename.SetActive(true);
        UniFilename.SetActive(false);
        FoodFilename.SetActive(false);
        rightFileSelected = true;
    }

    public void UniFile()
    {
        RightFilename.SetActive(false);
        UniFilename.SetActive(true);
        FoodFilename.SetActive(false);
        rightFileSelected = false;
    }

    public void FoodFile()
    {
        RightFilename.SetActive(false);
        UniFilename.SetActive(false);
        FoodFilename.SetActive(true);
        rightFileSelected = false;
    }
    
    void Start()
    {
        desktop.SetActive(true);
        RightFilename.SetActive(false);
        UniFilename.SetActive(false);
        FoodFilename.SetActive(false);
        error.SetActive(false);
        UploadTab.SetActive(false);
        colourGone = false;
        koreanWelcome.SetActive(false);

        english = GameObject.FindGameObjectsWithTag("English");
        korean = GameObject.FindGameObjectsWithTag("Korean");

        englishTitles.SetActive(true);
        koreanTitles.SetActive(false);

    }

    public void UploadButton()
    {
        if (rightFileSelected)
        {
            if (GC.hackerLeft)
            {
                successfulSub.SetActive(true);
                desktop.SetActive(false);

            }
            else
            {
                UploadTab.SetActive(false);
                error.SetActive(true);
                isUploaded = true;
            }


            
                        
            
        }
    }
   

    public void HackStart()
    {
        iconPop.CloseWindow();
        //Deactivate Gooble window
        reloadScreen.SetActive(true);
        desktop.SetActive(false);
    }

    public void ReloadDone()
    {
        errorUploadActivated = true;
        reloadScreen.SetActive(false);
        desktop.SetActive(true);
        colourGone = true;
        koreanWelcome.SetActive(true);
        englishTitles.SetActive(false);
        koreanTitles.SetActive(true);

        foreach (GameObject englishObject in english)
        {
            englishObject.SetActive(false);
            Debug.Log("English");
        }

        foreach (GameObject koreanObject in korean)
        {
            koreanObject.SetActive(true);
            Debug.Log("Korean");
        }

        

        //Reload Screen finishes and hacking starts...timer faster
        TimerController.instance.BeginTimer();
        Invoke("Disappear", 6.8f);
    }

    public void colourBack()
    {
        colourGone = false;
    }

    void Disappear()
    {
        koreanWelcome.SetActive(false);
        beginHack();
    }

    public void ClickDisappear()
    {
        koreanWelcome.SetActive(false);
        Invoke("beginHack", 4f);
    }

    public void beginHack()
    {
        hackerTerminal.SetActive(true);
    }

    void Update()
    {
        if (TimerController.instance.TimerText.text == "23:59")
        {
            timeOver.SetActive(true);
            desktop.SetActive(false);
        }
        if (colourGone)
        {
            foreach (GameObject item in colourItems)
            {
                item.SetActive(false);
            }

            foreach (GameObject item in greyItems)
            {
                item.SetActive(true);
            }
        }

        else
        {
            foreach (GameObject item in colourItems)
            {
                item.SetActive(true);
            }

            foreach (GameObject item in greyItems)
            {
                item.SetActive(false);
            }
        }
    }
}
