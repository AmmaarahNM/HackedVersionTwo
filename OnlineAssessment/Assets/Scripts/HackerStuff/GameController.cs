using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{    
    public Text playerText;
    public Text playerAnswerOne;
    public Text playerAnswerTwo;
    public Text playerAnswerThree;     

    public GameObject initialInput;
    public GameObject firstInput;
    public GameObject secondInput;
    public GameObject thirdInput;

    private string discover;
    private string AnswerOne;
    private string AnswerTwo;
    private string AnswerThree;

    public GameObject greeting;
    public GameObject comm;
    public GameObject OneQ;
    public GameObject TwoQ;
    public GameObject ThreeQ;
    public GameObject leaveTime;
    public GameObject right1;
    public GameObject right2;
    public GameObject right3;
    public GameObject wrong;

    public GameObject hackedMessage;
    
    public HackerCommunication hackerCom;
    public FurtherCommunication FurtherCom;
    public QuestionOne questionOne;
    public QuestionTwo questionTwo;
    public QuestionThree questionThree;
    public LeaveNow leave;
    public RightAnswerOne RightOne;
    public RightAnswerTwo RightTwo;
    public RightAnswerThree RightThree;
    public WrongAnswer wrongAnswer;

    public GameObject settings;
    public GameObject colour;
    public GameObject language;
    public GameObject antivirus;

    private InputField Input1;
    private InputField Input2;
    private InputField Input3;

    public GameObject copyText;
    public GameObject highlights;
    public GameObject rightclick;

    public bool hackerLeft;


    public bool isDiscovered;

    public void Start()
    {
        comm.SetActive(false);
        greeting.SetActive(true);
        Invoke("Surprise", 9f);
        hackerCom.Greet();
        
                
    }

    
    public void Surprise()
    {
        greeting.SetActive(false);
        hackedMessage.SetActive(true);
        Invoke("beginAgain", 4f);
    }

    public void beginAgain()
    {
        
        hackedMessage.SetActive(false);
        greeting.SetActive(true);
        hackerCom.Lesson();
        Invoke("ToExplain", 22f);
    }

    public void ToExplain()
    {
        hackerCom.Explain();
    }

    


    private void Awake()
    {

       discover = "";
        AnswerOne = "1511";
        AnswerTwo = "Kim Woosung";
        AnswerThree = "Horton";
        
    }

    public void GetInput (string guess)
    {
        playerText.text = guess;    
       
        if (guess.ToLower() != discover.ToLower())
        {            
            Debug.Log("Typed");
            Invoke("TypeComplete", 5f);
        }
        

    }

    public void TypeComplete()
    {
        Debug.Log("We can talk!");        
        initialInput.SetActive(false);
        comm.SetActive(true);        
        greeting.SetActive(false);        
        Invoke("FirstQ", 17f);

    }

    public void FirstQ()
    {
        comm.SetActive(false);
        OneQ.SetActive(true);          
        firstInput.SetActive(true);
    }


    public void GetAnswerOne(string first)
    {
        playerAnswerOne.text = first;

        if (first.ToLower() == AnswerOne.ToLower())
        {
            
            
            OneQ.SetActive(false);
            //Input1.enabled = false;
            wrong.SetActive(false);
            right1.SetActive(true);
            Invoke("colourSuccess", 10f);
            Debug.Log("FirstCorrect");

        }
        else
        {
            OneQ.SetActive(false);
            wrong.SetActive(true);
        }


    }

    public void colourSuccess()
    {
        settings.SetActive(true);
        colour.SetActive(true);
        
    }
    public void languageSuccess()
    {
        settings.SetActive(true);
        language.SetActive(true);
    }
    public void GetAnswerTwo(string second)
    {
        playerAnswerOne.text = second;

        if (second.ToLower() == AnswerTwo.ToLower())
        {
            copyText.SetActive(false);
            highlights.SetActive(false);
            rightclick.SetActive(false);
            TwoQ.SetActive(false);
            wrong.SetActive(false);
            right2.SetActive(true);
            right1.SetActive(false);
            //Input2.enabled = false;
            Invoke("languageSuccess", 10f);
            
            Debug.Log("SecondCorrect");
        }
        else
        {
            copyText.SetActive(false);
            TwoQ.SetActive(false);
            wrong.SetActive(true);
        }


    }

    public void GetAnswerThree(string third)
    {
        playerAnswerOne.text = third;

        if (third.ToLower() == AnswerThree.ToLower())
        {
            
            ThreeQ.SetActive(false);
            wrong.SetActive(false);
            right3.SetActive(true);
            right2.SetActive(false);
            
            //Input3.enabled = false;
            Debug.Log("ThirdCorrect");
            Invoke("corruptSuccess", 10f);
        }
        else
        {
            ThreeQ.SetActive(false);
            wrong.SetActive(true);
        }

    }

    public void corruptSuccess()
    {
        antivirus.SetActive(true);
    }

    public void TurnOnColour()
    {
        //turn colour on 
        right1.SetActive(false);
        settings.SetActive(false);
        colour.SetActive(false);
        TwoQ.SetActive(true);
        copyText.SetActive(true);
        secondInput.SetActive(true);
    }

    public void TurnOnLanguage()
    {
        right2.SetActive(false);
        settings.SetActive(false);
        language.SetActive(false);
        ThreeQ.SetActive(true);
        thirdInput.SetActive(true);
    }

    public void newAntivirus()
    {
        right3.SetActive(false);
        antivirus.SetActive(false);
        leaveTime.SetActive(true);
        right3.SetActive(false);
        Invoke("DisappearNow", 18f);
    }

    public void DisappearNow()
    {
        hackerLeft = true;
        leaveTime.SetActive(false);
    }
}