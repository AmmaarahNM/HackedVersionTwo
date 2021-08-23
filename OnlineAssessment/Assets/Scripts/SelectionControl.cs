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
    public GameObject rightClickMenu2;

    public GameObject enterText;
    public GameObject translateText;
    public GameObject pasteText;
    public GameObject translation;

    public bool overText;
    public bool isCopied;
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
        enterText.SetActive(true);
        pasteText.SetActive(false);
        translateText.SetActive(true);
        translation.SetActive(false);
        rightClickMenu2.SetActive(false);
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

        if (overText)
        {
            if (Input.GetMouseButtonDown(1))
            {
                Debug.Log("canClickey");
                rightClickMenu2.SetActive(true);
            }
        }
    }

    public void Copied()
    {
        
        rightClickMenu.SetActive(false);
        highlight.SetActive(false);
    }

    public void Paste()
    {
        isCopied = true;
        rightClickMenu2.SetActive(false);
        enterText.SetActive(false);
        pasteText.SetActive(true);
        overText = false;
    }

    public void Translating()
    {
        if (isCopied)
        {
            translateText.SetActive(false);
            translation.SetActive(true);
        }
        
    }

    public void pasteMenu()
    {
        overText = true;
    }

    public void noPaste()
    {
        overText = false;
    }
}
