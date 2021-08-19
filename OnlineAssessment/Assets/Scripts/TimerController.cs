using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class TimerController : MonoBehaviour
{
    private float StartingTime;

    public bool hasSartedTest;
    public GameObject clock;

    //public GameObject finished;
    
    public float TotalTime;

    public TMP_Text TimerText;

    public float minutes;
    public float hours;

    [Header("--Event Timer--")]
    public bool useEventTimer;
    public UnityEvent TimerEvent;

    private void Start()
    {
        StartingTime = TotalTime;
        clock.SetActive(true);
    }


    private void Update()
    {
        
        TotalTime += Time.deltaTime;
        
        
        hours = (int)(TotalTime / 360);
        minutes = (int)(TotalTime / 60);

        if (useEventTimer)
        {
            if (hours >= 23 && minutes >= 59)
            {
                
                TotalTime = StartingTime;
                Debug.Log("Event");
               // finished.SetActive(true);
                TimerEvent.Invoke();
            }
        }

        TimerText.text = hours.ToString() + " : " + minutes.ToString();

    }

    public void StartTestBtn()
    {
        hasSartedTest = true;
        

    }
}
