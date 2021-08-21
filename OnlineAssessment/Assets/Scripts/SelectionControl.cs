using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionControl : MonoBehaviour
{
    public GameObject highlight;
    public bool hoveredOver;
    public bool selected;

    public GameObject rightClickMenu;
   



    public void OnMouseOver()
    {
        highlight.SetActive(true);
        hoveredOver = true;

    }

    public void clickMouse()
    {
        if (hoveredOver)
        {
            highlight.SetActive(true);
            selected = true;
        }
    }

    public void OnMouseExit()
    {
        if (!selected)
        {
            highlight.SetActive(false);
            hoveredOver = false;
        }       
        
    }

    void Start()
    {
        highlight.SetActive(false);
    }

    
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            if (selected)
            {
                Debug.Log("RightClick");

                rightClickMenu.SetActive(true);

                
            }
        }
    }
}
