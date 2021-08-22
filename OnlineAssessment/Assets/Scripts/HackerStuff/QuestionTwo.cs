using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionTwo : MonoBehaviour
{
    public float delay = 0.1f;
   
    private string currentText = "";
    private string Two;

    void Awake()
    {
        Two = "So, I'm sure you're having a little trouble understanding" + "\n" + "things on your computer.." + "\n" + "But it's not really that hard to solve...." + "\n" + "Just click, right click and copy this text and if you find a way to get it." + "\n"
            + "back to English, it will guide you in finding the answer that I seek.";


    }

    public void Start()
    {
        StartCoroutine(TwoPuzzleText());
    }

    IEnumerator TwoPuzzleText()
    {
        for (int i = 0; i < Two.Length; i++)
        {
            currentText = Two.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);


        }
    }
}
