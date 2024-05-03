using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LB_RobTax : MonoBehaviour
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

            this.gameObject.GetComponentInParent<Lb_MoveTax>().PlayerInside = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            this.gameObject.GetComponentInParent<Lb_MoveTax>().PlayerInside = false;
        }
    }
}
