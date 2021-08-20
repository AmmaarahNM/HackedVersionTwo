using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniFilesManager : MonoBehaviour
{
    public IconPopUps IPUword;
    public WurdManager WM;
    public GameObject fileToOpen;
    public BottomTabIcons BTIuni;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        IPUword.OnMouseDown();
        if (gameObject.name == "CorrectAssignment")
        {
            WM.OpenCorruptedFile();
        }

        else
        {
            WM.AssignmentFile(fileToOpen);
        }

        BTIuni.OnMouseDown();

    }
}
