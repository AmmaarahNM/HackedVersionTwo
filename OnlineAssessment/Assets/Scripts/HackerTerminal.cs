using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HackerTerminal : MonoBehaviour
{
    //public GameObject hackedScreen;
    public GameObject terminal;

    public GameObject introText;
    public GameObject enterText;
    public Text playerText;
    public Text responseText;

    [SerializeField]
    private InputField input;

    private string answers;
    private string noAnswer;
    public bool activatedT;
    public bool cannot;
   // private string guessedAnswer;

    //private int guessCount;

    public GameManager GM;

   // public bool deactivateTerminal;

    public void Start()
    {

        //GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        input.DeactivateInputField();
        enterText.SetActive(false);
        cannot = true;


    }

    private void Update()
    {
        

        if (activatedT)
        {
            terminal.SetActive(true);
        }
        else
        {
            StartCoroutine(GoAway());
            
        }
    }

    IEnumerator GoAway()
    {
        //activatedT = false;
        yield return new WaitForSeconds(3f);
        terminal.SetActive(false);
        //GM.terminalActive = false;
    }
    public void startHack()
    {
        if (!GM.googleActive)
        {
            GM.goobleIcon.SetActive(false);
            GM.goobleText.SetActive(false);
            //GM.replacedIcon.SetActive(true);
            GM.goobleWindow.SetActive(false);
        }
        
        //GM.windowOpen = false;
        StartCoroutine(StartUp());
        
        Debug.Log("Plz");
    }

    public IEnumerator StartUp()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("Leave Dammit!");
        //hackedScreen.SetActive(false);
        /* if (!deactivateTerminal)
         {
             terminal.SetActive(true);
             GM.terminalActive = true;
         }*/
        if (cannot)
        {
            activatedT = true;
            //terminal.SetActive(true);
            //GM.terminalActive = true;
        }
        

        //yield return new WaitForSeconds(1f);
        introText.SetActive(true);

        //yield return new WaitForSeconds(4f);
        input.ActivateInputField();
        enterText.SetActive(true);
    }

    private void Awake()
    {

        answers = "He is bald";
        noAnswer = "";
        /*answers = new string[7];
        answers[0] = "He is bald";
        answers[1] = "He's bald";
        answers[2] = "He was bald";
        answers[3] = "Bald";
        answers[4] = "He has no hair";
        answers[5] = "He's got no hair";
        answers[6] = "No hair";*/

        //input = GameObject.Find("InputField").GetComponent<InputField>();
    }

    public void GetInput(string guess)
    {
        playerText.text = guess;
        input.text = "";
        input.ActivateInputField();

        if (guess.ToLower() == answers.ToLower())
        {
            responseText.text = "Congratulations!! You have" + "\n" + "successfully been distracted..." + "\n" + "I have breached your antivirus" + "\n" + "firewall! Enjoy fixing it >.<";
            Debug.Log("Your are RIGHT!!!");
            input.DeactivateInputField();
            cannot = false;
            activatedT = false;
            //GM.AntivirusBreach();
        }
        else if(guess.ToLower() == noAnswer.ToLower())
        {
            responseText.text = "";
            //activatedT = true;
        }
        else
        {
            responseText.text = "DING DING DING! WRONG!";
            Debug.Log("Your are WRONG!!!");
            //activatedT = true;
        }



        /* if (guess.ToLower() == answers.ToLower())
         {

             responseText.text = "Congratulations!! You have" + "\n" + "successfully been distracted..." + "\n" + "I have breached your antivirus" + "\n" + "firewall! Enjoy fixing it >.<";
             Debug.Log("Your are RIGHT!!!");
             Invoke("Bye", 4f);




             //GM.AntivirusBreach();
         }
         else
         {
             responseText.text = "DING DING DING! WRONG!";
             Debug.Log("Your are WRONG!!!");
         }*/




    }
    
    

    /*IEnumerator DeactivateTerminal()
    {
        yield return new WaitForSeconds(4f);
        terminal.SetActive(false);
        GM.terminalActive = false;
    }*/

   
}
