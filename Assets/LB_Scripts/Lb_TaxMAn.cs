using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lb_TaxMAn : MonoBehaviour
{
    public Transform Node1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("TaxMan"))
        {
            Node1.GetComponent<LB_NOde>().TaxLeft = true;
        }
    }
}
