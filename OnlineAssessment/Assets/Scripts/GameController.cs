using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    //public GameObject hackedScreen;
    //public GameObject terminal;

    //public GameObject introText;
    //public GameObject enterText;
    public Text playerText;
    public Text playerAnswerOne;
    public Text playerAnswerTwo;
    public Text playerAnswerThree;
    //public Text responseText;

    

    public GameObject initialInput;
    public GameObject firstInput;
    public GameObject secondInput;
    public GameObject thirdInput;

    private string discover;
    private string AnswerOne;
    private string AnswerTwo;
    private string AnswerThree;

    public GameObject greeting;
    public GameObject hackedMessage;
    // private string guessedAnswer;

    //private int guessCount;





    public void Start()
    {

        greeting.SetActive(true);
        Invoke("Surprise", 9f);

        //hackedScreen.SetActive(true);
        //StartCoroutine(StartUp());
       // input.DeactivateInputField();
        //enterText.SetActive(false);
                
    }

    public void Surprise()
    {
        greeting.SetActive(false);
        hackedMessage.SetActive(true);

    }

    private void Update()
    {
        

    }

    /*private IEnumerator StartUp()
    {
       // yield return new WaitForSeconds(3f);
        //hackedScreen.SetActive(false);

        //yield return new WaitForSeconds(1f);
       // introText.SetActive(true);

        //yield return new WaitForSeconds(4f);
        //input.ActivateInputField();
       // enterText.SetActive(true);
    }*/

    private void Awake()
    {

       discover = "";
        AnswerOne = "Kim Woosung";
        AnswerTwo = "1511";
        AnswerThree = "Horton";
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

    public void GetInput (string guess)
    {
        playerText.text = guess;
        
        //input.text = "";
       // input.ActivateInputField();

        if (guess.ToLower() != discover.ToLower())
        {
            //responseText.text = "Well Done";
            Debug.Log("Typed");
            Invoke("TypeComplete", 5f);
        }
        

    }

    public void TypeComplete()
    {
        Debug.Log("We can talk!");
        
        initialInput.SetActive(false);
        firstInput.SetActive(true);
    }


    public void GetAnswerOne(string first)
    {
        playerAnswerOne.text = first;

        //input.text = "";
        // input.ActivateInputField();

        if (first.ToLower() == AnswerOne.ToLower())
        {
            //responseText.text = "Well Done";
            Debug.Log("FirstCorrect");
        }


    }

    public void GetAnswerTwo(string second)
    {
        playerAnswerOne.text = second;

        //input.text = "";
        // input.ActivateInputField();

        if (second.ToLower() == AnswerTwo.ToLower())
        {
            //responseText.text = "Well Done";
            Debug.Log("SecondCorrect");
        }


    }

    public void GetAnswerThree(string third)
    {
        playerAnswerOne.text = third;

        //input.text = "";
        // input.ActivateInputField();

        if (third.ToLower() == AnswerThree.ToLower())
        {
            //responseText.text = "Well Done";
            Debug.Log("ThirdCorrect");
        }


    }
}
