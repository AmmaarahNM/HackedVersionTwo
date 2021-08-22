using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    public GameObject shadow;
    

    private void Start()
    {
        //shadow = gameObject.GetComponentInChildren <GameObject> ();
    }
    public void OnMouseOver()
    {

        shadow.SetActive(true);
    }



    public void OnMouseExit()
    {
        shadow.SetActive(false);
    }




}
