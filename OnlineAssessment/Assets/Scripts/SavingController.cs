using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using UnityEngine.Events;

public class SavingController : MonoBehaviour
{
    /*[Header("--Event Hacked--")]
    public bool useEventHacked;
    public UnityEvent HackedEvent;*/
    //public GameObject HackedWindow;

    public GameObject[] QuestionGroupArr;
    public QAClass[] QAArr;
    public GameObject AnswerPanel;
    public GameObject FinishPanel;
    public int SumbitCounter;

    public string CorrectQ1 = "Conscience";
    public string CorrectQ2 = "Maintenance";
    public string CorrectQ3 = "Recommend";
    public string CorrectQ4 = "Deductible";
    public string CorrectQ5 = "Pronunciation";

    public GameObject terminal;
    public HackerTerminal hackerScreen;

    public Image assignmentDoneLine;


    void Start()
    {
        terminal.SetActive(false);
        QAArr = new QAClass[QuestionGroupArr.Length];
    }


    private void Update()
    {
        if (SumbitCounter == 1)
        {
            Debug.Log("Hacked!!");
         
            //hackerScreen.startHack();

           

        }
        else if (SumbitCounter == 2)
        {
            Debug.Log("final submit");

            for (int i = 0; i < QAArr.Length; i++)
            {
                QAArr[i] = ReadQuestionAndAnswer(QuestionGroupArr[i]);
            }

            DisplayResults();
            assignmentDoneLine.enabled = true;
        }
    }


    public void SubmitAnswer()
    {
        SumbitCounter++;
        

    }

    QAClass ReadQuestionAndAnswer(GameObject questionGroup)
    {
        QAClass Result = new QAClass();

        GameObject q = questionGroup.transform.Find("Question").gameObject;
        GameObject a = questionGroup.transform.Find("Answer").gameObject;

        Result.Question = q.GetComponent<TMP_Text>().text;

        if (a.GetComponent<ToggleGroup>() != null)
        {
            for (int i = 0; i < a.transform.childCount; i++)
            {
                if (a.transform.GetChild(i).GetComponent<Toggle>().isOn)
                {
                    Result.Answer = a.transform.GetChild(i).Find("Label").GetComponent<TMP_Text>().text;
                    break;

                }
            }
        }
        else if (a.GetComponent<InputField>() != null)
        {

            Result.Answer = a.transform.Find("Text").GetComponent<Text>().text;

        }
        else if (a.GetComponent<ToggleGroup>() == null && a.GetComponent<InputField>() == null)
        {
            string s = "";
            int counter = 0;

            for (int i = 0; i < a.transform.childCount; i++)
            {
                if (a.transform.GetChild(i).GetComponent<Toggle>().isOn)
                {
                    if(counter != 0)
                    {
                        s = s + ", ";

                    }
                    s = s + a.transform.GetChild(i).Find("Label").GetComponent<TMP_Text>().text;
                    counter++;
                }

                if (i == a.transform.childCount - 1)
                {
                    s = s + ".";
                }
            }

            Result.Answer = s;
        }

        return Result;
    }

    void DisplayResults()
    {
        //TestWindow.SetActive(true);
        FinishPanel.SetActive(true);
        AnswerPanel.SetActive(true);

        string s = "";

        for (int i = 0; i < QAArr.Length; i++)
        {
            s = s + QAArr[i].Question + "\n";
            s = s + QAArr[i].Answer + "\n\n";
        }

        AnswerPanel.transform.Find("Answer").GetComponent<TMP_Text>().text = s;
    }
}

[System.Serializable]
public class QAClass
{
    public string Question = "";
    public string Answer = "";
    
}
