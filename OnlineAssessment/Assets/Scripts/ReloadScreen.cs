using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReloadScreen : MonoBehaviour
{
    public Text progressPercent;
    public int percent;
    public UploadScript uploadScript;


    void Update()
    {
        progressPercent.text = percent.ToString() + "%" + " Complete";
    }

    private void Start()
    {
        percent = 0;
        Invoke("One", 1f);
        
    }

    private void One()
    {
        percent = 5;
        Invoke("Two", 1f);
    }
    private void Two()
    {
        percent = 12;
        Invoke("Three", 1f);
    }
    private void Three()
    {
        percent = 18;
        Invoke("Four", 2f);
    }
    private void Four()
    {
        percent = 26;
        Invoke("Five", 2f);
    }
    private void Five()
    {
        percent = 36;
        Invoke("Six", 2f);
    }
    private void Six()
    {
        percent = 49;
        Invoke("Seven", 3f);
    }
    private void Seven()
    {
        percent = 60;
        Invoke("Eight", 3f);
    }
    private void Eight()
    {
        percent = 72;
        Invoke("Nine", 5f);
    }

    private void Nine()
    {
        percent = 93;
        Invoke("Ten", 5f);
    }

    private void Ten()
    {
        percent = 100;
        uploadScript.ReloadDone();
    }
}
