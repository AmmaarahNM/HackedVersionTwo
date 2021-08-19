using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //public bool virusActive;
   // public GameObject virus;
    //public Text virusButton;
    //public float spawnDelay;
    //float currentSpawnDelay;
    //public int virusSpawned;
    //public int virusDestroyed;

    //public Transform[] spawnPos;

    //public int codeFound;
   //public GameObject[] foundFiles;
    //public Animator anim;
    //public GameObject missingFilesText;
    //public GameObject securedFirewall;
    //public bool windowOpen;
    //public GameObject[] missingFiles;
    //public Text findFiles;
    //public Text fightVirus;
    public Text completeAssessment;
    //public IconPopUps virusIcon;
    //public Image virusesDefeatedLine;
    //public Image filesFoundLine;

    public GameObject goobleIcon;
    public GameObject goobleText;
    //public GameObject replacedIcon;

    public GameObject newEmail;
    public GameObject emailWindow;
    public GameObject bottomEmailIcon;
    public GameObject goobleWindow;

    //public bool terminalActive;
    //public bool filesFound;

    //public GameObject terminal;
    //public GameObject newTaunt;
    //public GameObject firewallWindow;

    //public GameObject lastTerminal;
    //public GameObject lastTaunt;

    public GameObject testWindow;

    public bool googleActive;
    //public bool terminalTwoActivated;
    // Start is called before the first frame update
    void Start()
    {
        //missingFilesText.SetActive(false);
        newEmail.SetActive(false);

        Invoke("Notify", 1.2f);
    }

    void Notify()
    {
        newEmail.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        /*if (virusActive)
        {
            //put fight off the virus in the sticky note
           if (currentSpawnDelay > 0)
            {
                currentSpawnDelay -= Time.deltaTime;
            }

           else
            {
                SpawnVirus();
                currentSpawnDelay = spawnDelay;
            }

           
            
        }

        if (virusDestroyed >= 20) //number of viruses needed to kill to win
        {
            virusActive = false;
            spawnDelay = 3;
            //deactivate button or whatever trigger ends up being used
            if (virusDestroyed >= virusSpawned)
            {
                virusSpawned = 0;
                virusDestroyed = 0;
                Debug.Log("Virus defeated!");
                virusesDefeatedLine.enabled = true;
                virusButton.text = "Activate Virus";
                
                StartCoroutine(VirusDefeated());
                
                //WIN FUNCTION
            }

        }*/

        /*if (codeFound ==1)
        {
            foundFiles[0].SetActive(true);
        }

        if (codeFound == 2)
        {
            foundFiles[1].SetActive(true);
            if (virusIcon.appWindow.activeSelf == true)
            {
                anim.SetBool("codeFound", true);
                StartCoroutine("SecureText");
                filesFoundLine.enabled = true;
            }
            
            



        }*/
      

        
    }

    /*IEnumerator VirusDefeated()
    {
        yield return new WaitForSeconds(3f);
        lastTerminal.SetActive(true);
        lastTaunt.SetActive(true);
        StartCoroutine(EndHack());
    }*/

    IEnumerator EndHack()
    {
        yield return new WaitForSeconds(5f);
        //lastTerminal.SetActive(false);
        //lastTaunt.SetActive(false);
        //replacedIcon.SetActive(false);
        googleActive = true;
        goobleIcon.SetActive(true);
        goobleText.SetActive(true);
        testWindow.SetActive(true);
    }

    /*public void AntivirusBreach()
    {
        if (!filesFound)
        {
            missingFilesText.SetActive(true);
            securedFirewall.SetActive(false);
           
            
        }

        if (missingFiles[0] != null)
        {
            missingFiles[0].SetActive(true);
        }

        if (missingFiles[1] != null)
        {
            missingFiles[1].SetActive(true);
        }

        findFiles.text = "Find the missing firewall files!";
    }*/
    

    public void OpenNewEmail()
    {
        newEmail.SetActive(false);
        emailWindow.SetActive(true);
        bottomEmailIcon.SetActive(true);
        //windowOpen = true;
        completeAssessment.text = "Complete online exam!";

    }

   /* public void SwitchWindows()
    {
        emailWindow.SetActive(false);
        goobleWindow.SetActive(true);
    }*/

    /*IEnumerator SecureText()
    {
        yield return new WaitForSeconds(2.1f);
        filesFound = true;
        missingFilesText.SetActive(false);
        securedFirewall.SetActive(true);
        //hacker new message
        
        if (!terminalTwoActivated)
        {
            StartCoroutine(ReactivateTerminal());
        }
        
    }*/
    /*public void SpawnVirus()
    {
        int randomSpawn = Random.Range(0, spawnPos.Length);
        Instantiate(virus, spawnPos[randomSpawn].position, Quaternion.identity);

        
    }*/

    /*IEnumerator ReactivateTerminal()
    {
        
        yield return new WaitForSeconds(3f);
        terminal.SetActive(true);
        newTaunt.SetActive(true);

        yield return new WaitForSeconds(8f);
        firewallWindow.SetActive(false);
        windowOpen = false;
        terminal.SetActive(false);
        newTaunt.SetActive(false);
        virusActive = true;
        fightVirus.text = "Destroy the baby viruses!";
        terminalTwoActivated = true;
    }*/

    /*public void VirusActivation()
    {
        if (virusActive)
        {
            virusActive = false;
            //virusButton.text = "Activate Virus";
            
        }

        else
        {
            //virusButton.text = "Deactivate Virus";
            virusActive = true;
            fightVirus.text = "Destroy the baby viruses!";
        }
    }*/
}
