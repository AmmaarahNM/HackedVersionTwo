using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightAnswerThree : MonoBehaviour
{
    public float delay3 = 0.1f;

    private string cuText = "";
    private string anotherOne;

    void Awake()
    {
        anotherOne = "Congrats! Now I think it's time you update that" + "\n" + "antivirus software...";


    }

    public void Start()
    {
        StartCoroutine(OneText());
    }

    IEnumerator OneText()
    {
        for (int i = 0; i < anotherOne.Length; i++)
        {
            cuText = anotherOne.Substring(0, i);
            this.GetComponent<Text>().text = cuText;
            yield return new WaitForSeconds(delay3);


        }
    }
}
