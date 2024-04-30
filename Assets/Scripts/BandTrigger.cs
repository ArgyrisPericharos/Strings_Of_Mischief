using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandTrigger : MonoBehaviour
{
    public GameManager Gamemanager;
    
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
            //Debug.Log("GeneralPublicHasGonein");
            other.gameObject.GetComponentInParent<LB_GenPublic>().BandOn = true;
            //generalpublic.GetComponent<LB_GenPublic>().BandOn = true;           
        }

        if (other.gameObject.CompareTag("Manhole"))
        {
            Gamemanager.GetComponent<DR_TruckCouncil>().WithinArea = true;
        }




        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("GeneralPublic"))
        {
            other.gameObject.GetComponentInParent<LB_GenPublic>().BandOn = false;
            //generalpublic.GetComponent<LB_GenPublic>().BandOn = false;
        }
    }
}
