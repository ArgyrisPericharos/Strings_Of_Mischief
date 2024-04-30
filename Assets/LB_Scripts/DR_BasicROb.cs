using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR_BasicROb : MonoBehaviour
{
    public GameManager GameManager;

    public bool PlayerIsInsideCrowdMember = false; //turn that on the camera script of the wii controls

    public bool CrowdMemberIsDistracted = false;

    public float ChanceOfGettingDistracted = 0f;

    public float CrowdSatisfactionLimit;

    public GameObject MainCamera;
    
    public GameObject HandsUp;
    public GameObject RobTrigger;


    public bool RollForChance;
    // Start is called before the first frame update
    void Start()
    {
        ChanceOfGettingDistracted = Random.Range(0, 100);
        RollForChance = false;
    }

    // Update is called once per frame
    void Update()
    {
        HandsUp.transform.LookAt(MainCamera.transform);

        if ( gameObject.GetComponent<LB_GenPublic>().BandOn)
        {
            if (RollForChance)
            {
                ChanceOfGettingDistracted = Random.Range(0, 100);
                RollForChance = false;
            }

            if (GameManager.CrowdSatisfaction >= CrowdSatisfactionLimit)
            {
                if (ChanceOfGettingDistracted >= 50)
                {
                    CrowdMemberIsDistracted = true;

                    HandsUp.SetActive(true);
                    RobTrigger.SetActive(true);
                }
                else if (ChanceOfGettingDistracted <= 50)
                {
                    CrowdMemberIsDistracted = false;

                    HandsUp.SetActive(false);
                    RobTrigger.SetActive(false);
                }
            }
            else if (GameManager.CrowdSatisfaction <= CrowdSatisfactionLimit)
            {
                CrowdMemberIsDistracted = false;
                HandsUp.SetActive(false);
                RobTrigger.SetActive(false);

            }
        }
        else if ( gameObject.GetComponent<LB_GenPublic>().BandOn!)
        {
            RollForChance = true;
        }


   
        if (CrowdMemberIsDistracted == true && PlayerIsInsideCrowdMember == true && Input.GetKeyUp(KeyCode.Q))
        {
            GameManager.GetComponent<GameManager>().money += Random.Range(5, 25);
        }
    }




   
}
