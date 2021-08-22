using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   
    //public Text completeAssessment;
    

    public GameObject goobleIcon;
    public GameObject goobleText;
    

    public GameObject newEmail;
    public GameObject emailWindow;
    public GameObject bottomEmailIcon;
    public GameObject goobleWindow;

    

    //public GameObject testWindow;

    public Animator anim;

    public int NotificationCounter;

   
    public GameObject OneNotificationImage;

    public GameObject welcome;

    public bool emailOpened;

    public bool googleActive;

    
    public GameObject rightClickMenu2;

    public GameObject enterText;
    public GameObject translateText;
    public GameObject pasteText;
    public GameObject translation;

    public GameObject EmailNotificationBar;
    public GameObject BWEmailNotificationBar;
    public NotificationStuffTab NST;
    public Text BWname;
    public Text COLname;



    void Start()
    {
        enterText.SetActive(true);
        pasteText.SetActive(false);
        translateText.SetActive(true);
        translation.SetActive(false);
        rightClickMenu2.SetActive(false);
        Invoke("Welcome", 1.2f);
        BWname.text = PlayerPrefs.GetString("name", "");
        COLname.text = PlayerPrefs.GetString("name", "");

    }

    void Welcome()
    {
        welcome.SetActive(true);
        Invoke("Disappear", 6.8f);
    }

    void Disappear()
    {
        welcome.SetActive(false);
        Invoke("Notify", 3f);
    }

    public void ClickDisappear()
    {
        welcome.SetActive(false);
    }

    void Notify()
    {
       
        NotificationCounter++;
        anim.SetBool("isNotified", true);
       
    }
    
    void Update()
    {
      
       

        NotificationTab();

        if (emailOpened == true)
        {
            OneNotificationImage.SetActive(false);
        }
        else
        {
            OneNotificationImage.SetActive(true);
        }
        
    }

   

    /*IEnumerator EndHack()
    {
        yield return new WaitForSeconds(5f);
        
        googleActive = true;
        goobleIcon.SetActive(true);
        goobleText.SetActive(true);
        testWindow.SetActive(true);
    }*/

   
    

    public void OpenNewEmail()
    {
        emailOpened = true;

        newEmail.SetActive(false);
        emailWindow.SetActive(true);
        bottomEmailIcon.SetActive(true);
        EmailNotificationBar.SetActive(false);
        BWEmailNotificationBar.SetActive(false);
        if (NST.notificationTabOpen)
        {
            NST.OnMouseDown();
        }
        
        //NotificationWindow.SetActive(false);
        
        
        
        
    }
   
    public void NotificationTab()
    {
        if (NotificationCounter != null)
        {
            if (NotificationCounter == 1)
            {
                OneNotificationImage.SetActive(true);
            }
            
        }
        else
        {
            OneNotificationImage.SetActive(false);
        }
    }
}
