using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR_CrowdEngagement : MonoBehaviour
{
    public float crowdEngagement = 5.0f; // Change this variable to change the amount of crowd engagement that a player starts off with, at the start of each level

    // Start is called before the first frame update
    void Start()
    {
        CallCrowdEngagementDecreaser();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.G) == true)
        {
            crowdEngagement += 0.5f; // Change this float to change the amount of crowd engagement that a player gains, every time they play a input on their instrument
        }

        if (crowdEngagement <= 0.0f)
        {
            crowdEngagement = 0.0f;
        }
    }

    public void CallCrowdEngagementDecreaser()
    {
        StartCoroutine(CrowdEngagementDecreaser());
    }

    IEnumerator CrowdEngagementDecreaser()
    {
        yield return new WaitForSeconds(2f); // Change this float to change the amount of time that goes by, between every loss of crowd engagement

        crowdEngagement -= 0.2f; // Change this float to change the amount of crowd engagement that a player loses, for every time-amount that goes by

        CallCrowdEngagementDecreaser();
    }
}
