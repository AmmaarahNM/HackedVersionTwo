using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HackerCommunication : MonoBehaviour
{
    public float delay = 0.1f;
    private string greeting;
    private string lessons;
    private string explaination;
    private string discovery;
    private string One;
    private string Two;
    private string Three;
    private string Leave;

    private string currentText = "";
       
    public string playerName;

    

    
    void Awake()
    {
        playerName = PlayerPrefs.GetString("name", "");
        greeting = "Why hello there" + ", " + playerName + " !" + "...Guess what?!";

        lessons = "Don't get me wrong, I'm really not such a bad guy... well sort of." + "\n" + "\n" + "I'm just trying to teach you a little lesson about the" + 
        "\n" + "consequences of completing assignments at the last minute.";

        explaination = "So, here's the deal, we are going to have a little fun!" + "\n" + "I have three puzzles for you to solve, each in the form of a" + "\n" + "riddle or question." + "\n" + "You will have to search your computer to figure out the answer." + "\n" 
            + "For each correct answer, I will allow you to" + "\n" + "fix your computer bit by bit"
        + "\n" + "\n" + "Before we start, why don't you figure out how to" + "\n" + "communicate with me?" + "\n" + "Go ahead...";

        
    }
   

    public void Greet()
    {
        StartCoroutine(GreetText());
    }

    public void Lesson()
    {
        StartCoroutine(LessonText());
    }

    public void Explain()
    {
        StartCoroutine(ExplainText());
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

    IEnumerator LessonText()
    {
        for (int i = 0; i < lessons.Length; i++)
        {
            currentText = lessons.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);


        }
    }

    IEnumerator ExplainText()
    {
        for (int i = 0; i < explaination.Length; i++)
        {
            currentText = explaination.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);


        }
    }



}
