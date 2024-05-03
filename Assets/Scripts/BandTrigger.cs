using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandTrigger : MonoBehaviour
{
    //public GameObject generalpublic;
    public bool BandOn;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider other)
    {
        //Debug.Log("Somethinghasgonein" + other.gameObject.name);
        //here we make an if statement with all the robbable actions, we turn on their respective bools that acitvate them Like the truck/manhole, shop and civilians
        if (other.gameObject.CompareTag("GeneralPublic"))
        {
            other.gameObject.GetComponentInParent<LB_GenPublic>().BandOn = true;
        }
        if (other.gameObject.CompareTag("PublicFan"))
        {
            other.gameObject.GetComponentInParent<LB_GenFAn>().BandOn = true;
        }
        if (other.gameObject.CompareTag("WeddingMember"))
        {
            other.gameObject.GetComponentInParent<LB_Wedding>().BandOn = true;
        }
        if (other.gameObject.CompareTag("Manhole"))
        {
            gameManager.GetComponent<DR_TruckCouncil>().WithinArea = true;
        }
        if (other.gameObject.CompareTag("TaxMan"))
        {
            other.gameObject.GetComponentInParent<Lb_MoveTax>().BandOn = true;
        }
        if (other.gameObject.CompareTag("Construction"))
        {
            other.gameObject.GetComponentInParent<LB_Construction>().BandOn = true;
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("GeneralPublic"))
        {
            other.gameObject.GetComponentInParent<LB_GenPublic>().BandOn = false;
        }
        if (other.gameObject.CompareTag("PublicFan"))
        {
            other.gameObject.GetComponentInParent<LB_GenFAn>().BandOn = false;
        }
        if (other.gameObject.CompareTag("WeddingMember"))
        {
            other.gameObject.GetComponentInParent<LB_Wedding>().BandOn = false;
        }
        if (other.gameObject.CompareTag("Manhole"))
        {
            gameManager.GetComponent<DR_TruckCouncil>().WithinArea = false;
        }
        if (other.gameObject.CompareTag("TaxMan"))
        {
            other.gameObject.GetComponentInParent<Lb_MoveTax>().BandOn = false;
        }
        if (other.gameObject.CompareTag("Construction"))
        {
            other.gameObject.GetComponentInParent<LB_Construction>().BandOn = false;
        }
    }
}
