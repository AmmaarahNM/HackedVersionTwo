using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FurtherCommunication : MonoBehaviour
{
    public float delay = 0.1f;
    private string discovery;
    private string currentText = "";

    void Awake()
    {
        discovery = "Ahh, so you have found out how to talk" + "\n" + "to me...let us begin then, shall we?" + "\n" + "\n" + "And remember, the answers are not as simple as they may seem...";
             

    }

    public void Start()
    {
        StartCoroutine(DiscoverText());
    }

    IEnumerator DiscoverText()
    {
        for (int i = 0; i < discovery.Length; i++)
        {
            currentText = discovery.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);


        }
    }

}
