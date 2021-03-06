using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameManager GM;

    private string Start = "DesktopTwo";

    public GameObject startWindow;
    public GameObject grayStart;

    public void StartBtn()
    {
        SceneManager.LoadScene(1);
    }

    public void closeStart()
    {
        startWindow.SetActive(false);
        grayStart.SetActive(false);
    }

    public void DoneBtn()
    {
        //if (GM.virusSpawned == 0)
        //{
            Application.Quit();
            Debug.Log("Quitting...");
        //}
        
    }

    public void PowerOff()
    {
        Application.Quit();
        Debug.Log("Quitting...");
    }


    public void Begin()
    {
        SceneManager.LoadScene(Start);
    }


    public void LogOff()
    {
        SceneManager.LoadScene(0);
    }

    public void LoginScreen()
    {
        SceneManager.LoadScene("LoginScreen");
    }
}
