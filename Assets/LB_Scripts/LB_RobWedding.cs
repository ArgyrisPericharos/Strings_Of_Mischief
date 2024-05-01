using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LB_RobWedding : MonoBehaviour
{
    public Camera Camera;
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

            this.gameObject.GetComponentInParent<LB_Wedding>().PlayerInside = true;
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

            this.gameObject.GetComponentInParent<LB_Wedding>().PlayerInside = false;
        }
    }
}
