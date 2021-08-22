using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationStuffTab : MonoBehaviour
{
    public bool notificationTabOpen;
    public GameObject notificationWindow;

    public GameManager GM;

    
    public void OnMouseDown()
    {
        if (!notificationTabOpen)
        {
           /* if (GM.NotificationCounter != null)
            {
                GM.emailOpened == true;
                GM.OneNotificationImage.SetActive(false);
            }*/

            notificationWindow.SetActive(true);
            notificationTabOpen = true;
        }

        else
        {
            notificationWindow.SetActive(false);
            notificationTabOpen = false;
            
        }

        
    }
}
