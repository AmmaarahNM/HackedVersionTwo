using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionOne : MonoBehaviour
{
    public float delay = 0.1f;
    
    private string currentText = "";
    private string One;

    void Awake()
    {
        One = "So first, here's a little riddle...." + "\n" + "\n" + "The solution is not the answer, but it will" + "\n" + "give you an idea on what to look for.." + "\n" + "The answer that I am looking for is something numerical!..."
          + "\n" + "\n" + "If a red house is made from red bricks" + "\n" + "and a yellow house from yellow bricks" + "\n" + "what is a greenhouse made from?" ;


    }

    public void Start()
    {
        StartCoroutine(OnePuzzleText());
    }

    IEnumerator OnePuzzleText()
    {
        for (int i = 0; i < One.Length; i++)
        {
            currentText = One.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);


        }
    }
}
