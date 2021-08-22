using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmailControlScript : MonoBehaviour
{
    public GameObject Email1;
    public GameObject Email2;
    public GameObject Email3;
    public GameObject Email4;
    public GameObject Email5;
    public GameObject Email6;
    public GameObject Email7;



    public void Start()
    {
        Email1.SetActive(true);
        Email2.SetActive(false);
        Email3.SetActive(false);
        Email4.SetActive(false);
        Email5.SetActive(false);
        Email6.SetActive(false);
        Email7.SetActive(false);
    }


    public void OpenOne()
    {
        Email1.SetActive(true);
        Email2.SetActive(false);
        Email3.SetActive(false);
        Email4.SetActive(false);
        Email5.SetActive(false);
        Email6.SetActive(false);
        Email7.SetActive(false);
    }

    public void OpenTwo()
    {
        Email1.SetActive(false);
        Email2.SetActive(true);
        Email3.SetActive(false);
        Email4.SetActive(false);
        Email5.SetActive(false);
        Email6.SetActive(false);
        Email7.SetActive(false);
    }

    public void OpenThree()
    {
        Email1.SetActive(false);
        Email2.SetActive(false);
        Email3.SetActive(true);
        Email4.SetActive(false);
        Email5.SetActive(false);
        Email6.SetActive(false);
        Email7.SetActive(false);
    }

    public void OpenFour()
    {
        Email1.SetActive(false);
        Email2.SetActive(false);
        Email3.SetActive(false);
        Email4.SetActive(true);
        Email5.SetActive(false);
        Email6.SetActive(false);
        Email7.SetActive(false);
    }

    public void OpenFive()
    {
        Email1.SetActive(false);
        Email2.SetActive(false);
        Email3.SetActive(false);
        Email4.SetActive(false);
        Email5.SetActive(true);
        Email6.SetActive(false);
        Email7.SetActive(false);
    }

    public void OpenSix()
    {
        Email1.SetActive(false);
        Email2.SetActive(false);
        Email3.SetActive(false);
        Email4.SetActive(false);
        Email5.SetActive(false);
        Email6.SetActive(true);
        Email7.SetActive(false);
    }

    public void OpenSeven()
    {
        Email1.SetActive(false);
        Email2.SetActive(false);
        Email3.SetActive(false);
        Email4.SetActive(false);
        Email5.SetActive(false);
        Email6.SetActive(false);
        Email7.SetActive(true);
    }
}
