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

    public bool WorkerShopJewelryIsFullyDistracted = false;
    
    public bool ShopJewelryCanBeRobbed = false;

    public float workerShopJewelryMovementDuration = 5.0f; // Change this variable to change how quickly the worker jewelry shop will get to their destination, when they move

    void Start()
    {
        WorkerShopJewelryCurrentPosition.transform.position = WorkerShopJewelryStartPosition.transform.position;
    }

    void Update()
    {
        if (GetComponent<DR_CrowdEngagement>().crowdEngagement >= 10.0f && WorkerShopJewelryCanLeaveShop == true)
            // Change this variable to change the amount of crowd engagement that a player needs, to trigger the worker jewelry shop to come out
        {
            WorkerShopJewelryCanLeaveShop = false;

            WorkerShopJewelry.SetActive(true);

            ShopJewelryDoorLeftOpen.SetActive(true);
            ShopJewelryDoorRightOpen.SetActive(true);
            ShopJewelryDoorLeftClosed.SetActive(false);
            ShopJewelryDoorRightClosed.SetActive(false);

            StartCoroutine(MoveWorkerShopJewelryTowardsPoint(workerShopJewelryMovementDuration));
        }

        if (WorkerShopJewelryIsFullyDistracted == true)
        {
            ShopJewelryCanBeRobbed = true;

            ShopJewelryRobbingArea.SetActive(true);
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

        WorkerShopJewelry.transform.position = workerShopJewelryEngagedPosition;

        WorkerShopJewelryCurrentPosition.transform.position = workerShopJewelryEngagedPosition;

        WorkerShopJewelryIsFullyDistracted = true;
    }
}
