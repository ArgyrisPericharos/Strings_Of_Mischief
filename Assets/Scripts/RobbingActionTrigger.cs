using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobbingActionTrigger : MonoBehaviour
{
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            this.gameObject.GetComponentInParent<DR_BasicROb>().PlayerIsInsideCrowdMember = true;
            if (Camera.GetComponent<WiimoteDemo>().MinusPressed)
            {
               // PlayerIsInsideCrowdMember = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            this.gameObject.GetComponentInParent<DR_BasicROb>().PlayerIsInsideCrowdMember = false;
        }
    }
}
