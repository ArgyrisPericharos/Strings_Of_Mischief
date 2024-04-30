using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR_CrowdMemberRob : MonoBehaviour
{
    public bool PlayerIsInsideCrowdMember = false;

    public bool CrowdMemberIsDistracted = false;

    public float Money = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CrowdMemberIsDistracted == true && PlayerIsInsideCrowdMember == true && Input.GetKeyUp(KeyCode.Q))
        {
            Money += Random.Range(5, 25);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerIsInsideCrowdMember = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerIsInsideCrowdMember = false;
        }
    }
}
