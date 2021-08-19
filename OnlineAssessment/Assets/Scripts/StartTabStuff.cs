using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTabStuff : MonoBehaviour
{
    bool startTabOpen;
    public GameObject startWindow;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (!startTabOpen)
        {
            startWindow.SetActive(true);
            startTabOpen = true;
        }

        else
        {
            startWindow.SetActive(false);
            startTabOpen = false;
        }

    }
}
