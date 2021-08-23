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
    public GameObject wifi;
    public GameObject antivirus;

    public GameObject Input1;
    public GameObject Input2;
    public GameObject Input3;

    public GameObject copyText;
    public GameObject highlights;
    public GameObject rightclick;

    public UploadScript upload;

    public GameObject[] english;
    public GameObject[] korean;

    public GameObject koreanTitles;
    public GameObject englishTitles;

    public bool hackerLeft;

    public GameObject[] stickyKorean;
    public GameObject[] stickyEnglish;

    public bool isDiscovered;
    public bool thirdSucces;

    public StrypifyManager bwSM;
    public GameManager GM;

    public GameObject inputText1;
    public GameObject inputText2;
    public GameObject inputText3;

    public bool wasHacked;


    public GameObject Eng1;
    public GameObject Eng2;
    public GameObject Eng3;
    public GameObject Eng4;
    public GameObject Kor1;
    public GameObject Kor2;
    public GameObject Kor3;
    public GameObject Kor4;

    public GameObject updateButton;
    public void Start()
    {
        comm.SetActive(false);
        greeting.SetActive(true);
        Invoke("Surprise", 6f);
        hackerCom.Greet();
        wifi.SetActive(true);
        Eng1.SetActive(false);
        Eng2.SetActive(false);
        Eng3.SetActive(false);
        Eng4.SetActive(false);
        Kor1.SetActive(true);
        Kor2.SetActive(true);
        Kor3.SetActive(true);
        Kor4.SetActive(true);


        english = GameObject.FindGameObjectsWithTag("English");
        korean = GameObject.FindGameObjectsWithTag("Korean");

        inputText1.SetActive(false);
        inputText2.SetActive(false);
        inputText3.SetActive(false);

    }

    
    public void Surprise()
    {
        greeting.SetActive(false);
        hackedMessage.SetActive(true);
        Invoke("beginAgain", 3f);
    }

    public void beginAgain()
    {
        
        hackedMessage.SetActive(false);
        greeting.SetActive(true);
        hackerCom.Lesson();
        Invoke("ToExplain", 17f);
    }

    public void ToExplain()
    {
        wasHacked = true;
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
        if (wasHacked)
        {
            playerText.text = guess;

            if (guess.ToLower() != discover.ToLower())
            {
                Debug.Log("Typed");
                Invoke("TypeComplete", 4f);
            }
        }
        
        

    }

    public void TypeComplete()
    {
        Debug.Log("We can talk!");        
        initialInput.SetActive(false);

        comm.SetActive(true);        
        greeting.SetActive(false);        
        Invoke("FirstQ", 12f);

    }

    public void FirstQ()
    {
        comm.SetActive(false);
        OneQ.SetActive(true);
        Invoke("firstInputActive", 18f);
        
    }

    public void firstInputActive()
    {
        firstInput.SetActive(true);
    }

    public void secondInputActive()
    {
        secondInput.SetActive(true);
    }

    public void thirdInputActive()
    {
        thirdInput.SetActive(true);
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
            Invoke("colourSuccess", 7f);
            Debug.Log("FirstCorrect");

        }
        else
        {
            OneQ.SetActive(false);
            wrong.SetActive(true);
            Invoke("ReactivateRiddleOne", 4f);
        }


    }

    public void ReactivateRiddleOne()
    {
        wrong.SetActive(false);
        OneQ.SetActive(true);
    }

    public void ReactivateRiddleTwo()
    {
        wrong.SetActive(false);
        TwoQ.SetActive(true);
        copyText.SetActive(true);
        highlights.SetActive(true);
        rightclick.SetActive(true);
    }

    public void ReactivateRiddleThree()
    {
        wrong.SetActive(false);
        ThreeQ.SetActive(true);
    }

    public void colourSuccess()
    {
        wifi.SetActive(false);
        settings.SetActive(true);
        colour.SetActive(true);
        Eng1.SetActive(false);
        Eng2.SetActive(false);
        Eng3.SetActive(false);
        Eng4.SetActive(false);
        Kor1.SetActive(true);
        Kor2.SetActive(true);
        Kor3.SetActive(true);
        Kor4.SetActive(true);
        Input1.SetActive(false);
        inputText1.SetActive(true);

        foreach (GameObject stickyText in stickyKorean)
        {
            stickyText.SetActive(true);
        }
        
    }
    public void languageSuccess()
    {
        wifi.SetActive(false);
        settings.SetActive(true);
        language.SetActive(true);
        Eng1.SetActive(false);
        Eng2.SetActive(false);
        Eng3.SetActive(false);
        Eng4.SetActive(false);
        Kor1.SetActive(true);
        Kor2.SetActive(true);
        Kor3.SetActive(true);
        Kor4.SetActive(true);
        Input2.SetActive(false);
        inputText2.SetActive(true);

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
            Invoke("languageSuccess", 7f);
            
            Debug.Log("SecondCorrect");
        }
        else
        {
            copyText.SetActive(false);
            TwoQ.SetActive(false);
            wrong.SetActive(true);
            Invoke("ReactivateRiddleTwo", 4f);
        }


    }

    public void GetAnswerThree(string third)
    {
        playerAnswerOne.text = third;

        if (third.ToLower() == AnswerThree.ToLower())
        {
            
            
            thirdSucces = true;
            ThreeQ.SetActive(false);
            wrong.SetActive(false);
            right3.SetActive(true);
            right2.SetActive(false);
            
            //Input3.enabled = false;
            Debug.Log("ThirdCorrect");
            Invoke("corruptSuccess", 7f);
        }
        else
        {
            ThreeQ.SetActive(false);
            wrong.SetActive(true);
            Invoke("ReactivateRiddleThree", 4f);
        }

    }

    public void corruptSuccess()
    {
        antivirus.SetActive(true);
        updateButton.SetActive(true);
        Input3.SetActive(false);
        inputText3.SetActive(true);
    }

    public void TurnOnColour()
    {
        
        upload.colourBack();
        right1.SetActive(false);
        settings.SetActive(false);
        colour.SetActive(false);
        TwoQ.SetActive(true);
        copyText.SetActive(true);
        Invoke("secondInputActive", 18f);

        /*foreach (AudioSource songIndex in bwSM.songs)
        {
            songIndex.Stop();
        }
        GM.musicPlaying = false;*/
    }

    public void TurnOnLanguage()
    {
        englishTitles.SetActive(true);
        koreanTitles.SetActive(false);
        foreach (GameObject englishObject in english)
       {
            englishObject.SetActive(true);
       }

        foreach (GameObject koreanObject in korean)
        {
            koreanObject.SetActive(false);
        }

        right2.SetActive(false);
        settings.SetActive(false);
        language.SetActive(false);
        wifi.SetActive(true);
        ThreeQ.SetActive(true);
        Invoke("thirdInputActive", 18f);

        foreach (GameObject stickyText in stickyKorean)
        {
            stickyText.SetActive(false);
        }

        foreach (GameObject stickyText in stickyEnglish)
        {
            stickyText.SetActive(true);
        }

        Eng1.SetActive(true);
        Eng2.SetActive(true);
        Eng3.SetActive(true);
        Eng4.SetActive(true);
        Kor1.SetActive(false);
        Kor2.SetActive(false);
        Kor3.SetActive(false);
        Kor4.SetActive(false);
    }

    public void newAntivirus()
    {
        if (thirdSucces)
        {
            
            right3.SetActive(false);
            antivirus.SetActive(false);
            leaveTime.SetActive(true);
            right3.SetActive(false);
            //hackerLeft = true;
            Invoke("DisappearNow", 13f);
        }
        
    }

    public void DisappearNow()
    {
        hackerLeft = true;
        leaveTime.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
