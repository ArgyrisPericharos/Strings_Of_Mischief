using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LB_BalconeOn : MonoBehaviour
{
    public bool BalconyOn;
    public GameManager GameManager;
    public float minimum;
    public GameObject balconyMember;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.CrowdSatisfaction >= minimum)
        {

            BalconyOn = true;
            balconyMember.SetActive(true);
            
        }
    }
}
