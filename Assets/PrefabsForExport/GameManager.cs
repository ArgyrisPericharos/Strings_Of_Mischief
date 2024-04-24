using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //CrowdSatisfaction information
    public int CrowdSatisfaction = 60;
    public Image CrowdBar;


    //playingsong information
    public bool startsong;
    public float TimeGoBy;
    public GameObject AudioSource;
    public List<AudioClip> ListOfSongs;

    

    // Start is called before the first frame update
    void Start()
    {
        CrowdSatisfaction = 40;

   

    }

    // Update is called once per frame
    void Update()
    {
        if (startsong == true)
        {
            TimeGoBy += Time.deltaTime;
        }
        

        CrowdSatisfaction = Mathf.Clamp(CrowdSatisfaction, 0, 100);

        CrowdBar.fillAmount = CrowdSatisfaction / 100f;

    }


    
}
