using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightAnswerOne : MonoBehaviour
{
    public float delay1 = 0.1f;

    private string thisText = "";
    private string thisOne;

    void Awake()
    {
        thisOne = "Well done! You can now change your display settings" + "\n" + "and fix your colour problem.";


    }

    public void Start()
    {
        StartCoroutine(OneAnswer());
    }

    IEnumerator OneAnswer()
    {
        for (int i = 0; i < thisOne.Length; i++)
        {
            thisText = thisOne.Substring(0, i);
            this.GetComponent<Text>().text = thisText;
            yield return new WaitForSeconds(delay1);


        }
    }
}
