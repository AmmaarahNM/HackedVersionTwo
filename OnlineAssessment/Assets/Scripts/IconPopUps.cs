﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconPopUps : MonoBehaviour
{
    GameManager GM;
    public GameObject appWindow;
    public GameObject bottomTabIcon;
    public bool thiswWindowOpen;
    public RectTransform appWindowTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log(gameObject.name + " clicked");
        
        
        GM.newEmail.SetActive(false);
        GM.completeAssessment.text = "Complete and submit online assignment!";
        appWindow.SetActive(true);
        bottomTabIcon.SetActive(true);
        thiswWindowOpen = true;
        appWindowTransform.SetAsLastSibling();

        //GM.windowOpen = true;

        //sound of enemy dying
        FindObjectOfType<MusicManager>().Play("CorrectSound");
        
    }

    public void CloseWindow()
    {
        appWindow.SetActive(false);
        bottomTabIcon.SetActive(false);
        thiswWindowOpen = false;
        //GM.windowOpen = false;
    }

}
