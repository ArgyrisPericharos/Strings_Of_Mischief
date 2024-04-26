using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robable : MonoBehaviour
{
    public GameObject HandsUp;
    public GameObject RobTrigger;
    public bool RobableC;
    public GameObject MainCamera;   // Start is called before the first frame update
    public float ChanceOfDistracted;
    public bool RollForChance;
    public bool ActivateCoroutines;
    void Start()
    {
        RobableC = false;
        RollForChance = true;
        ActivateCoroutines = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (RobableC)
        {
            if (RollForChance)
            {
                ChanceOfDistracted = Random.Range(0, 100);
                RollForChance = false;
            }
            
            if (ChanceOfDistracted >= 50) 
            {
                this.gameObject.GetComponent<DR_CrowdMemberAIMovement>().StopAllCoroutines();
                this.gameObject.GetComponent<DR_CrowdMemberAIMovement>().enabled = false;
                HandsUp.SetActive(true);
                RobTrigger.SetActive(true);
                HandsUp.transform.LookAt(MainCamera.transform);
                ActivateCoroutines = true;
            }
            else if (ChanceOfDistracted <= 51)
            {
                HandsUp.SetActive(false);
                RobTrigger.SetActive(false);
                this.gameObject.GetComponent<DR_CrowdMemberAIMovement>().enabled = true;

                if (ActivateCoroutines) 
                {
                    this.gameObject.GetComponent<DR_CrowdMemberAIMovement>().StartCoroutine(this.gameObject.GetComponent<DR_CrowdMemberAIMovement>().ChangeRotationAndMovePeriodically());
                    ActivateCoroutines = false;
                }
                
            }
            //this.gameObject.GetComponent<DR_CrowdMemberAIMovement>().StopCoroutine(this.gameObject.GetComponent<DR_CrowdMemberAIMovement>().ChangeRotationAndMovePeriodically());
            
        }
        else if (RobableC == false)
        {
            HandsUp.SetActive(false);
            RobTrigger.SetActive(false);
            this.gameObject.GetComponent<DR_CrowdMemberAIMovement>().enabled = true;
            if (ActivateCoroutines)
            {
                this.gameObject.GetComponent<DR_CrowdMemberAIMovement>().StartCoroutine(this.gameObject.GetComponent<DR_CrowdMemberAIMovement>().ChangeRotationAndMovePeriodically());
                ActivateCoroutines = false;
            }
            RollForChance = true;
        }
    }
}
