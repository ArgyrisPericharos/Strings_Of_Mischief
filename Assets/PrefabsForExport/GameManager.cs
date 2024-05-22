 using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    //CrowdSatisfaction information
    public float CrowdSatisfaction = 60;
    public Image CrowdBar;

    //playingsong information
    public bool startsong;
    public float TimeGoBy;
    public GameObject AudioSource; //audio source that has the clip
    public GameObject Band;
    public GameObject BandSpawnPoint;
    public List<AudioClip> ListOfSongs; // this is used to assign the correct clip to the audio source

    // song list, these songs will get assigned in the Note list in ChartSystemManager script.
    public List<NoteData> SongOne;
    public List<NoteData> SongTwo;
    
    //Notes hit, Notes missed
    public float NotesHit;
    public float NotesMissed;
    //successprecentage
    public float NoteSuccessrate; // (NotesHit / (Noteshit + NotesMissed)) * 100 = (precentage of success rate)

    

    public bool InSpawnableArea; //this would be changeable based on where the player is at in the level (trigger box placements)

    public TMP_Text SuccessRatetext;
    public TMP_Text MoneyText;
    public GameObject Canvas;
    public Camera maincamera;

    //public Text textMoney; //money UI text
    public float money = 0.0f; //money value


    //menu panel manipulation. Turning on and off, navigating for the two different songs
    public List<TMP_Text> SongListMenu;
    public Image KnobNav;
    public int CurrentSelectionNum;
    public GameObject MenuPanel;
    public bool SelectedSong; // boolean that controls when to put song list into chart system, this is needed so it doesnt happen constantly
    public bool MenuOn; //turn this on from wiimote script

    void Start()
    {
        CrowdSatisfaction = 40;
        MenuOn = false;
        AudioSource.SetActive(false);
        SongOne = new List<NoteData> (this.gameObject.GetComponent<ChartSystemManager>().ChartNoteList);
        CurrentSelectionNum = 0;
        SelectedSong = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.GetComponent<ChartSystemManager>().ChartNoteList.Count <= 1)
        {
            Canvas.SetActive(true);
        }
        else
        {
            Canvas.SetActive(false);
        }
        if (this.gameObject.GetComponent<ChartSystemManager>().ChartNoteList.Count <= 0)
        {
            GameObject[] gos = GameObject.FindGameObjectsWithTag("Delete"); 
            foreach(GameObject go in gos)
            {
                Destroy(go);
            }

            startsong = false;
            AudioSource.transform.position = Band.transform.position;
            Band.transform.position = BandSpawnPoint.transform.position;
            AudioSource.SetActive(false);
            this.gameObject.GetComponent<ChartSystemManager>().Timemodifier = 1.33f;
            this.gameObject.GetComponent<ChartSystemManager>().ChartNoteList = new List<NoteData>(SongOne);
        }

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

        CurrentSelectionNum = Mathf.Clamp(CurrentSelectionNum, 0, 1);

        CrowdBar.fillAmount = CrowdSatisfaction / 100f;

        NoteSuccessrate = NotesHit / (NotesHit + NotesMissed) * 100;

        SuccessRatetext.text = (NoteSuccessrate.ToString("F0") + "%");
        //textMoney.text = "Money  =  $ " + money.ToString("F2");
        MoneyText.text = money.ToString() + "$";

        KnobNav.transform.position = new Vector3(SongListMenu[CurrentSelectionNum].transform.position.x + 150, SongListMenu[CurrentSelectionNum].transform.position.y);

        if(CurrentSelectionNum == 0 && SelectedSong) //this might need a boolean that checks when is done so the list moving happens only once.
        {
            //selected song one so put the right objects in the list
            this.gameObject.GetComponent<ChartSystemManager>().ChartNoteList = new List<NoteData>(SongOne);
            SelectedSong = false;
            //here i also have to change the audio source. since im changing the chart i also have to change the audible 
        }
        else if (CurrentSelectionNum == 1 && SelectedSong) //this might need a boolean that checks when is done so the list moving happens only once.
        {
            //selected song two so put the rigt objects in the list
            this.gameObject.GetComponent<ChartSystemManager>().ChartNoteList = new List<NoteData>(SongTwo);
            SelectedSong = false;
            //here i also have to change the audio source. since im changing the chart i also have to change the audible 
        }

        if (MenuOn)
        {
            MenuPanel.SetActive(true);
        } 
        else if (MenuOn == false)
        {
            MenuPanel.SetActive(false);
        }

        if (maincamera.GetComponent<WiimoteDemo>().GUIGo == true)
        {
            if (Input.GetKeyUp("e"))
            {
                maincamera.GetComponent<WiimoteDemo>().GUIGo = false;
                // gamemanager.SetActive(true);
            }
        }
        else if (maincamera.GetComponent<WiimoteDemo>().GUIGo == false)
        {
            if (Input.GetKeyUp("e"))
            {
                maincamera.GetComponent<WiimoteDemo>().GUIGo = true;
            }
        }


    }


    
    
}
