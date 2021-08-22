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


    public void openUpload()
    {
        if (isUploaded)
        {
            Invoke("HackStart", 0f);
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
        reloadScreen.SetActive(true);
        desktop.SetActive(false);
    }

    public void ReloadDone()
    {
        reloadScreen.SetActive(false);
        desktop.SetActive(true);
        colourGone = true;
        koreanWelcome.SetActive(true);
        //Reload Screen finishes and hacking starts...timer faster
        TimerController.instance.BeginTimer();
        Invoke("Disappear", 6.8f);
    }

    void Disappear()
    {
        koreanWelcome.SetActive(false);
        Invoke("beginHack", 4f);
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
