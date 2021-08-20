using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomTabIcons : MonoBehaviour
{
    public IconPopUps IPU;
    public GameObject appWindow;
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
        if (IPU.thiswWindowOpen == true)
        {
            appWindow.SetActive(false);
            IPU.thiswWindowOpen = false;
            IPU.appWindowTransform.SetAsFirstSibling();
        }

        else
        {
            appWindow.SetActive(true);
            IPU.thiswWindowOpen = true;
            IPU.appWindowTransform.SetAsLastSibling();
        }
    }
}
