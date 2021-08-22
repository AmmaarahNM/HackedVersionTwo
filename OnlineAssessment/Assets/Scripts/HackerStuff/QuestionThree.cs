using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionThree : MonoBehaviour
{
    public float delay = 0.1f;
   
    private string currentText = "";
    private string Three;

    void Awake()
    {
        Three = "Now lastly, I'm sure you want to fix those corrupted files." + "\n" + "\n" + "There is something on your laptop that should have been protecting it." + "\n" +
            "A little while ago, communication was received regarding that thing." + "\n" + "That which was original, is the answer I seek..";


    }

    public void Start()
    {
        StartCoroutine(ThreePuzzleText());
    }

    IEnumerator ThreePuzzleText()
    {
        for (int i = 0; i < Three.Length; i++)
        {
            currentText = Three.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);


        }
    }
}
