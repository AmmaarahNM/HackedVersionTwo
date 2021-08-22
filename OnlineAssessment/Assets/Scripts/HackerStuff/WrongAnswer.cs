using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WrongAnswer : MonoBehaviour
{
    public float delay4 = 0.1f;

    private string rentText = "";
    private string aOne;

    void Awake()
    {
        aOne = "Nope! Try again...";


    }

    public void Start()
    {
        StartCoroutine(PuzzleText());
    }

    IEnumerator PuzzleText()
    {
        for (int i = 0; i < aOne.Length; i++)
        {
            rentText = aOne.Substring(0, i);
            this.GetComponent<Text>().text = rentText;
            yield return new WaitForSeconds(delay4);


        }
    }
}
