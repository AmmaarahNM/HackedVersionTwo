using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using System;

public class TimerController : MonoBehaviour
{
    //private float StartingTime;

    //public bool hasSartedTest;

    public static TimerController instance;

    public bool timerGoing;

    private float elapsedTime;

    private TimeSpan timePlaying;

    public GameObject clock;

    public int timerSpeed;

    public bool isHacked;

    //public GameObject finished;
    
    //public float TotalTime;

    public TMP_Text TimerText;
    public Text timertext;

    //public float minutes;
    //public float hours;

    /* [Header("--Event Timer--")]
     public bool useEventTimer;
     public UnityEvent TimerEvent;*/
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        //StartingTime = TotalTime;
        //clock.SetActive(true);

        timerGoing = false;
    }

    public void BeginTimer()
    {
        timerGoing = true;
        isHacked = true;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()
    {
        timerGoing = false;
    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime*20;
            timePlaying = TimeSpan.FromMinutes(elapsedTime);
            string startTimePlayText = timePlaying.ToString("hh':'mm");
            TimerText.text = startTimePlayText;

            yield return null;
        }
    }

    /*private void Update()
    {
        
        TotalTime += Time.deltaTime*timerSpeed;
        
        
        hours = (int)(TotalTime / 360);
        minutes = (int)(TotalTime / 60);
       

        if (useEventTimer)
        {
            if (hours >= 23 && minutes >= 59)
            {
                
                TotalTime = StartingTime;
                //Debug.Log("Event");
               // finished.SetActive(true);
                TimerEvent.Invoke();
            }
        }

        TimerText.text = hours.ToString() + " : " + minutes.ToString();

    }

    public void StartTestBtn()
    {
        hasSartedTest = true;
        

    }*/


    private void Update()
    {
        if (isHacked == false)
        {
            DateTime time = DateTime.Now;
            string hour = LeadingZero(time.Hour);
            string minute = LeadingZero(time.Minute);

            TimerText.text = hour + ":" + minute;
            
        }

    }

    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }



}
