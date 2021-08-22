using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WurdManager : MonoBehaviour
{
    public GameObject firstOpen;
    //public GameObject newFile;
    public GameObject assignmentFile;
    public IconPopUps IPU;
    public GameObject[] files;

    // Start is called before the first frame update
    void Start()
    {
        firstOpen.SetActive(true);
        //newFile.SetActive(false);
        assignmentFile.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewDoc()
    {
        firstOpen.SetActive(false);
        //newFile.SetActive(true);
    }

    public void OpenCorruptedFile()
    {
        if (TimerController.instance.isHacked)
        {
            //close first open
            //open corrupted file
        }

        else
        {
            firstOpen.SetActive(false);
            assignmentFile.SetActive(true);
        }

    }

    public void AssignmentFile(GameObject file)
    {

        firstOpen.SetActive(false);
        file.SetActive(true);
        
    }

    public void Back()
    {
        firstOpen.SetActive(true);
        foreach (GameObject file in files)
        {
            file.SetActive(false);
        }
        
        
    }
}
