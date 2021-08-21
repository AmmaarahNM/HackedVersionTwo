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

    public GameObject door;
    public GameObject notify;
    public GameObject bubble;


    public void openUpload()
    {
        UploadTab.SetActive(true);
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
        RightFilename.SetActive(false);
        UniFilename.SetActive(false);
        FoodFilename.SetActive(false);
        error.SetActive(false);
        UploadTab.SetActive(false);
    }

    public void UploadButton()
    {
        if (rightFileSelected)
        {
            UploadTab.SetActive(false);
            error.SetActive(true);

            Invoke("HackStart", 6f);
        }
    }
   

    public void HackStart()
    {
        reloadScreen.SetActive(true);
        door.SetActive(false);
        notify.SetActive(false);
        bubble.SetActive(false);
    }

    public void ReloadDone()
    {
        reloadScreen.SetActive(false);
        door.SetActive(true);
        notify.SetActive(true);
        bubble.SetActive(true);

        //Reload Screen finishes and hacking starts...timer faster
    }
    void Update()
    {
        
    }
}
