using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR_ShopJewelry : MonoBehaviour
{
    public GameObject ShopJewelryDoorLeftClosed;
    public GameObject ShopJewelryDoorRightClosed;
    public GameObject ShopJewelryDoorLeftOpen;
    public GameObject ShopJewelryDoorRightOpen;

    public GameObject ShopJewelryRobbingArea;

    public GameObject WorkerShopJewelry;
    public GameObject WorkerShopJewelryStartPosition;
    public GameObject WorkerShopJewelryCurrentPosition;
    public GameObject WorkerShopJewelryEngagedPosition;

    public bool WorkerShopJewelryCanLeaveShop = true;
    public bool ShopJewelryCanBeRobbed = false;

    public float workerShopJewelryMovementDuration = 3.5f; // Change this variable to change how quickly the worker jewelry shop will get to their destination, when they move

    void Start()
    {
        WorkerShopJewelryCurrentPosition.transform.position = WorkerShopJewelryStartPosition.transform.position;
    }

    void Update()
    {
        if (GetComponent<DR_CrowdEngagement>().crowdEngagement >= 15.0f && WorkerShopJewelryCanLeaveShop == true) 
            // Change this variable to change the amount of crowd engagement that a player needs, to trigger the worker jewelry shop to come out
        {
            WorkerShopJewelryCanLeaveShop = false;

            ShopJewelryDoorLeftOpen.SetActive(true);
            ShopJewelryDoorRightOpen.SetActive(true);
            ShopJewelryDoorLeftClosed.SetActive(false);
            ShopJewelryDoorRightClosed.SetActive(false);

            ShopJewelryRobbingArea.SetActive(true);

            StartCoroutine(MoveWorkerShopJewelryTowardsPoint(workerShopJewelryMovementDuration));
        }

        if (WorkerShopJewelryCanLeaveShop == true)
        {
            ShopJewelryCanBeRobbed = true;
        }
    }

    IEnumerator MoveWorkerShopJewelryTowardsPoint(float workerShopJewelryMovementDuration)
    {
        Vector3 workerShopJewelryStartPosition = WorkerShopJewelryStartPosition.transform.position;
        Vector3 workerShopJewelryEngagedPosition = WorkerShopJewelryEngagedPosition.transform.position;
        float startWorkerShopJewelryMovementTime = Time.time;

        while (Time.time - startWorkerShopJewelryMovementTime < workerShopJewelryMovementDuration)
        {
            float t = (Time.time - startWorkerShopJewelryMovementTime) / workerShopJewelryMovementDuration;
            WorkerShopJewelry.transform.position = Vector3.Lerp(workerShopJewelryStartPosition, workerShopJewelryEngagedPosition, t);
            yield return null;
        }

        // Ensure the final position is exact to avoid floating-point errors
        WorkerShopJewelry.transform.position = workerShopJewelryEngagedPosition;

        // Update current point
        WorkerShopJewelryCurrentPosition.transform.position = workerShopJewelryEngagedPosition;
    }
}
