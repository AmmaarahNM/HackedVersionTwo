using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightAnswerTwo : MonoBehaviour
{
    public float delay2 = 0.1f;

    private string currText = "";
    private string thatOne;

    void Awake()
    {
        thatOne = "Look at you go!" + "\n" + "You can now change your language back..";


    }

    public void Start()
    {
        StartCoroutine(ThisText());
    }

    IEnumerator ThisText()
    {
        for (int i = 0; i < thatOne.Length; i++)
        {
            currText = thatOne.Substring(0, i);
            this.GetComponent<Text>().text = currText;
            yield return new WaitForSeconds(delay2);


        }
    }
}
