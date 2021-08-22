using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerName : MonoBehaviour
{   
    public string savedName;
    public Text inputText;
    private string empty;
    public GameObject username;
    public GameObject loading;
    public bool inputactive;
    public InputField input;

    
    private void Start()
    {
        PlayerPrefs.DeleteAll();
        username.SetActive(false);
        inputactive = true;
        loading.SetActive(false);

    }

    private void Awake()
    {
        empty = "";
    }

    public void Update()
    {
        if (inputactive)
        {
            input.ActivateInputField();
        }
    }
    public void SetName()
    {
        if(inputText.text != empty)
        {
            loading.SetActive(true);
            SceneManager.LoadScene("DesktopTwo");            
            username.SetActive(false);
            savedName = inputText.text;
            PlayerPrefs.SetString("name", savedName);            
            

        }
        else
        {
            username.SetActive(true);
            Debug.Log("Insert name");
            inputactive = true;
        }
        
    }

    public void CreditsLoad()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Leave()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }


}
