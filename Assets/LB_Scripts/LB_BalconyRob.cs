using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LB_BalconyRob : MonoBehaviour
{
    public bool RollForChance;
    public GameManager GameManager;

    public bool PlayerIsInsideCrowdMember = false; //turn that on the camera script of the wii controls

    public bool CrowdMemberIsDistracted = false;

    public float ChanceOfGettingDistracted = 0f;

    public float CrowdSatisfactionLimit;

    public GameObject MainCamera;

    public GameObject HandsUp;
    public GameObject RobTrigger;
    public float speed = 1f;
    public Transform Band;
    public GameObject Balcon;
    // Start is called before the first frame update
    void Start()
    {
        ChanceOfGettingDistracted = 50f;
        RollForChance = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        HandsUp.transform.LookAt(MainCamera.transform);
        

        if (Balcon.gameObject.GetComponent<LB_BalconeOn>().BalconyOn)
        {
            if (RollForChance)
            {
                //ChanceOfGettingDistracted = Random.Range(0, 100);
                RollForChance = false;
            }

            if (GameManager.CrowdSatisfaction >= CrowdSatisfactionLimit)
            {
                if (ChanceOfGettingDistracted >= 50)
                {
                    CrowdMemberIsDistracted = true;

                    HandsUp.SetActive(true);
                    RobTrigger.SetActive(true);
                    float singleStep = speed * Time.deltaTime;
                    Vector3 targetrotation = Band.position - transform.position;
                    Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetrotation, singleStep, 0.0f);
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
        else if (gameObject.GetComponent<LB_BalconeOn>().BalconyOn!)
        {
            RollForChance = true;
        }



        if (CrowdMemberIsDistracted == true && PlayerIsInsideCrowdMember == true && MainCamera.GetComponent<WiimoteDemo>().MinusPressed)
        {
            GameManager.GetComponent<GameManager>().money += Random.Range(5, 25);
        }
    }
}
