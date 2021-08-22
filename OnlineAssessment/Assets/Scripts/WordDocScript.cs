using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDocScript : MonoBehaviour
{

    public GameObject Doc1;
    public GameObject Doc2;
    public GameObject Doc3;
    public GameObject Doc4;
    public GameObject Doc5;
    public GameObject Doc6;
    public GameObject Doc7;

    void Start()
    {
        Doc1.SetActive(false);
        Doc2.SetActive(false);
        Doc3.SetActive(false);
        Doc4.SetActive(false);
        Doc5.SetActive(false);
        Doc6.SetActive(false);
        Doc7.SetActive(false);

    }

    public void openDoc1()
    {
        Doc1.SetActive(true);
        Doc2.SetActive(false);
        Doc3.SetActive(false);
        Doc4.SetActive(false);
        Doc5.SetActive(false);
        Doc6.SetActive(false);
        Doc7.SetActive(false);
    }
    public void openDoc2()
    {
        Doc1.SetActive(false);
        Doc2.SetActive(true);
        Doc3.SetActive(false);
        Doc4.SetActive(false);
        Doc5.SetActive(false);
        Doc6.SetActive(false);
        Doc7.SetActive(false);
    }
    public void openDoc3()
    {
        Doc1.SetActive(false);
        Doc2.SetActive(false);
        Doc3.SetActive(true);
        Doc4.SetActive(false);
        Doc5.SetActive(false);
        Doc6.SetActive(false);
        Doc7.SetActive(false);
    }
    public void openDoc4()
    {
        Doc1.SetActive(false);
        Doc2.SetActive(false);
        Doc3.SetActive(false);
        Doc4.SetActive(true);
        Doc5.SetActive(false);
        Doc6.SetActive(false);
        Doc7.SetActive(false);
    }
    public void openDoc5()
    {
        Doc1.SetActive(false);
        Doc2.SetActive(false);
        Doc3.SetActive(false);
        Doc4.SetActive(false);
        Doc5.SetActive(true);
        Doc6.SetActive(false);
        Doc7.SetActive(false);
    }
    public void openDoc6()
    {
        Doc1.SetActive(false);
        Doc2.SetActive(false);
        Doc3.SetActive(false);
        Doc4.SetActive(false);
        Doc5.SetActive(false);
        Doc6.SetActive(true);
        Doc7.SetActive(false);
    }
    public void openDoc7()
    {
        Doc1.SetActive(false);
        Doc2.SetActive(false);
        Doc3.SetActive(false);
        Doc4.SetActive(false);
        Doc5.SetActive(false);
        Doc6.SetActive(false);
        Doc7.SetActive(true);
    }

    public void goBack()
    {
        Doc1.SetActive(false);
        Doc2.SetActive(false);
        Doc3.SetActive(false);
        Doc4.SetActive(false);
        Doc5.SetActive(false);
        Doc6.SetActive(false);
        Doc7.SetActive(false);
    }
}
