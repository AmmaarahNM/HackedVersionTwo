using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaveNow : MonoBehaviour
{
    public float delay = 0.1f;
    
    private string currentText = "";
    private string Leave;

    void Awake()
    {
        Leave = "Well done!." + "\n" + "\n" + "You have succeeded in entertaining me!." + "\n" + "I hope that you've learned your lesson... and you may" + "\n" + "want to submit that assignment." + "\n" + "\n" + "Until next time, my friend;).";


    }

    public void Start()
    {
        StartCoroutine(LeaveText());
    }

    IEnumerator LeaveText()
    {
        for (int i = 0; i < Leave.Length; i++)
        {
            currentText = Leave.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);


        }
    }
}
