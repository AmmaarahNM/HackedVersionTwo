using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HackerCommunication : MonoBehaviour
{
    public float delay = 0.1f;
    private string greeting;
    
    private string currentText = "";
       
    public string playerName;

    

    
    void Awake()
    {
        playerName = PlayerPrefs.GetString("name", "");
        greeting = "Why hello there" + ", " + playerName + " !" + "...Guess what?!";
        

    }
    private void Start()
    {
        StartCoroutine(GreetText());
    }


    void Update()
    {
        
        
    }

    IEnumerator GreetText()
    {
        for (int i = 0; i< greeting.Length; i++)
        {
            currentText = greeting.Substring(0,i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
                       
                                  
        }
    }

    
 
}
