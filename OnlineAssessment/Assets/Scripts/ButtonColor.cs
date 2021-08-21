using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour
{
    public GameObject highlight;

    public void Entering()
    {
        highlight.SetActive(true);
    }

    public void Exiting()
    {
        highlight.SetActive(false);
    }
}
