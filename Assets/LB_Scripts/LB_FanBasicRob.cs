using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LB_FanBasicRob : MonoBehaviour
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
    public bool Robable;
    // Start is called before the first frame update
    void Start()
    {
        ChanceOfGettingDistracted = Random.Range(0, 100);
        RollForChance = false;
        Robable = true;
    }

    // Update is called once per frame
    void Update()
    {
        HandsUp.transform.LookAt(MainCamera.transform);

        if (gameObject.GetComponent<LB_GenFAn>().BandOn)
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
        else if (gameObject.GetComponent<LB_GenFAn>().BandOn!)
        {
            RollForChance = true;
            Robable = true;
        }



        if (CrowdMemberIsDistracted == true && PlayerIsInsideCrowdMember == true && MainCamera.GetComponent<WiimoteDemo>().MinusPressed && Robable)
        {
            GameManager.GetComponent<GameManager>().money += Random.Range(5, 25);
            Robable = false;
        }
    }
}
