using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR_WorkerTruckCouncil : MonoBehaviour
{
    public GameObject TruckCouncilRobbingArea;

    public GameObject WorkerTruckCouncil;
    public GameObject WorkerTruckCouncilStartPosition;
    public GameObject WorkerTruckCouncilCurrentPosition;
    public GameObject WorkerTruckCouncilEngagedPosition;

    public bool WorkerTruckCouncilIsFullyDistracted = false;

    public bool TruckCouncilCanBeRobbed = false;

    public float workerTruckCouncilMovementDuration = 5.0f; // Change this variable to change how quickly the truck council will get to its destination, when it moves

    public bool TruckCouncilRobbingAreaHasSpawned = false;

    void Start()
    {
        WorkerTruckCouncilCurrentPosition.transform.position = WorkerTruckCouncilStartPosition.transform.position;
    }

    void Update()
    {
        if (GetComponent<DR_TruckCouncil>().WorkerTruckCouncilCanBeSpawned == true && TruckCouncilRobbingAreaHasSpawned == false)
        // Change this variable to change the amount of crowd engagement that a player needs, to trigger the truck council to come out
        {
            StartCoroutine(MoveWorkerTruckCouncilTowardsPoint(workerTruckCouncilMovementDuration));
        }

        if (WorkerTruckCouncilIsFullyDistracted == true)
        {
            TruckCouncilRobbingAreaHasSpawned = true;

            TruckCouncilCanBeRobbed = true;

            TruckCouncilRobbingArea.SetActive(true);
        }
    }

    IEnumerator MoveWorkerTruckCouncilTowardsPoint(float workerTruckCouncilMovementDuration)
    {
        Vector3 workerTruckCouncilStartPosition = WorkerTruckCouncilStartPosition.transform.position;
        Vector3 workerTruckCouncilEngagedPosition = WorkerTruckCouncilEngagedPosition.transform.position;
        float startWorkerTruckCouncilMovementTime = Time.time;

        while (Time.time - startWorkerTruckCouncilMovementTime < workerTruckCouncilMovementDuration)
        {
            float t = (Time.time - startWorkerTruckCouncilMovementTime) / workerTruckCouncilMovementDuration;
            WorkerTruckCouncil.transform.position = Vector3.Lerp(workerTruckCouncilStartPosition, workerTruckCouncilEngagedPosition, t);
            yield return null;
        }

        WorkerTruckCouncil.transform.position = workerTruckCouncilEngagedPosition;

        WorkerTruckCouncilCurrentPosition.transform.position = workerTruckCouncilEngagedPosition;

        WorkerTruckCouncilIsFullyDistracted = true;
    }
}
