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
    public float seconds;

    [Header("--Event Timer--")]
    public bool useEventTimer;
    public UnityEvent TimerEvent;

    private void Start()
    {
        StartingTime = TotalTime;
        
    }


    private void Update()
    {
        if (hasSartedTest)
        {
            TotalTime -= Time.deltaTime;
        }
        
        minutes = (int)(TotalTime / 60);
        seconds = (int)(TotalTime % 60);

        if (useEventTimer)
        {
            if (minutes <= 0 && seconds <= 0)
            {
                
                TotalTime = 0;
                Debug.Log("Event");
               // finished.SetActive(true);
                TimerEvent.Invoke();
            }
        }

        TimerText.text = minutes.ToString() + " : " + seconds.ToString();

    }

    public void StartTestBtn()
    {
        hasSartedTest = true;
        clock.SetActive(true);

    }
}
