using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconPopUps : MonoBehaviour
{
    GameManager GM;
    public GameObject appWindow;
    public GameObject bottomTabIcon;
    public bool thiswWindowOpen;
    public RectTransform appWindowTransform;

    public GameObject[] otherWindows;
    public IconPopUps[] otherBoolChecks;



    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        if (GM.emailOpened == true)
        {
            GM.OneNotificationImage.SetActive(true);
        }
    }

    public void DeactivateOtherWindows()
    {
        foreach (GameObject window in otherWindows)
        {
            window.SetActive(false);
        }

        foreach (IconPopUps script in otherBoolChecks)
        {
            script.thiswWindowOpen = false;
            script.appWindowTransform.SetAsFirstSibling();
        }
    }
    public void OnMouseDown()
    {
        Debug.Log(gameObject.name + " clicked");
        
        
        GM.newEmail.SetActive(false);
        //GM.completeAssessment.text = "Complete and submit online assignment!";
        appWindow.SetActive(true);
        bottomTabIcon.SetActive(true);
        thiswWindowOpen = true;
        appWindowTransform.SetAsLastSibling();

        if (gameObject.name == "EmailIcon")
        {
            GM.EmailNotificationBar.SetActive(false);
            GM.BWEmailNotificationBar.SetActive(false);
        }

        DeactivateOtherWindows();

        //GM.windowOpen = true;

        //sound of enemy dying
        FindObjectOfType<MusicManager>().Play("CorrectSound");

        if (appWindow.name == "EmailWindow")
        {
            GM.emailOpened = true;
        }

    }

    public void CloseWindow()
    {
        appWindow.SetActive(false);
        bottomTabIcon.SetActive(false);
        thiswWindowOpen = false;
        //GM.windowOpen = false;
    }

}
