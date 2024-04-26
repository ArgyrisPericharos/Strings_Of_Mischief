using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    //CrowdSatisfaction information
    public float CrowdSatisfaction = 60;
    public Image CrowdBar;

    //playingsong information
    public bool startsong;
    public float TimeGoBy;
    public GameObject AudioSource; //audio source that has the clip
    public List<AudioClip> ListOfSongs; // this is used to assign the correct clip to the audio source

    // song list, these songs will get assigned in the Note list in ChartSystemManager script.
    public List<NoteData> SongOne;
    public List<NoteData> SongTwo;
    
    //Notes hit, Notes missed
    public float NotesHit;
    public float NotesMissed;
    //successprecentage
    public float NoteSuccessrate; // (NotesHit / (Noteshit + NotesMissed)) * 100 = (precentage of success rate)

    public bool MenuOn; //turn this on from wiimote script

    public bool InSpawnableArea; //this would be changeable based on where the player is at in the level (trigger box placements)


    //public Text textMoney; //money UI text
    public float money = 0.0f; //money value
    void Start()
    {
        CrowdSatisfaction = 40;
        MenuOn = false;
        AudioSource.SetActive(false);
   
        
    }

    // Update is called once per frame
    void Update()
    {
        // CrowdSatisfaction -= ;
        if (startsong == true)
        {
            TimeGoBy += Time.deltaTime;
        }
        else if (startsong == false)
        {
            TimeGoBy = 0;
            NotesHit = 0;
            NotesMissed = 0;
        }

        CrowdSatisfaction -= Time.deltaTime;

        CrowdSatisfaction = Mathf.Clamp(CrowdSatisfaction, 0, 100);

        CrowdBar.fillAmount = CrowdSatisfaction / 100f;

        //textMoney.text = "Money  =  $ " + money.ToString("F2");

    }


    
    
}
