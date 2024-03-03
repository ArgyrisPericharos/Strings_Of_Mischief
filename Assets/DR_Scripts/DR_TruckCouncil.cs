using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR_TruckCouncil : MonoBehaviour
{
    public GameObject ManholeCover;

    public GameObject TruckCouncil;
    public GameObject TruckCouncilStartPosition;
    public GameObject TruckCouncilCurrentPosition;
    public GameObject TruckCouncilEngagedPosition;

    public GameObject WorkerTruckCouncil;

    public bool WorkerTruckCouncilCanBeSpawned = false;

    public float truckCouncilMovementDuration = 5.0f; // Change this variable to change how quickly the truck council will get to its destination, when it moves

    void Start()
    {
        TruckCouncilCurrentPosition.transform.position = TruckCouncilStartPosition.transform.position;
    }

    void Update()
    {
        if (GetComponent<DR_CrowdEngagement>().crowdEngagement >= 15.0f)
        // Change this variable to change the amount of crowd engagement that a player needs, to trigger the truck council to come out
        {
            ManholeCover.SetActive(false);

            StartCoroutine(MoveTruckCouncilTowardsPoint(truckCouncilMovementDuration));
        }

        if (WorkerTruckCouncilCanBeSpawned == true)
        {
            WorkerTruckCouncilCanBeSpawned = false;

            WorkerTruckCouncil.SetActive(true);
        }
    }

    IEnumerator MoveTruckCouncilTowardsPoint(float truckCouncilMovementDuration)
    {
        Vector3 truckCouncilStartPosition = TruckCouncilStartPosition.transform.position;
        Vector3 truckCouncilEngagedPosition = TruckCouncilEngagedPosition.transform.position;
        float startTruckCouncilMovementTime = Time.time;

        while (Time.time - startTruckCouncilMovementTime < truckCouncilMovementDuration)
        {
            float t = (Time.time - startTruckCouncilMovementTime) / truckCouncilMovementDuration;
            TruckCouncil.transform.position = Vector3.Lerp(truckCouncilStartPosition, truckCouncilEngagedPosition, t);
            yield return null;
        }

        TruckCouncil.transform.position = truckCouncilEngagedPosition;

        TruckCouncilCurrentPosition.transform.position = truckCouncilEngagedPosition;

        WorkerTruckCouncilCanBeSpawned = true;
    }
}
