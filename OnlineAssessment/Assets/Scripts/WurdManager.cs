using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WurdManager : MonoBehaviour
{
    public GameObject firstOpen;
    public GameObject newFile;
    public GameObject assignmentFile;
    public IconPopUps IPU;
    // Start is called before the first frame update
    void Start()
    {
        firstOpen.SetActive(true);
        newFile.SetActive(false);
        assignmentFile.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewDoc()
    {
        firstOpen.SetActive(false);
        newFile.SetActive(true);
    }

    public void AssignmentFile()
    {
        //if not solved - error about file path shows up
        //sets off whole search
        //else open assignment file
    }

    public void Back()
    {
        firstOpen.SetActive(true);
        assignmentFile.SetActive(false);
        newFile.SetActive(false);
    }
}
