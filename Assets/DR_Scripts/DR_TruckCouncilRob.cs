using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR_TruckCouncilRob : MonoBehaviour
{
    public GameObject GameManager;

    public bool PlayerHasRobbedTruckCouncil = false;

    public bool PlayerHasEnteredTruckCouncilRobbingArea = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.GetComponent<DR_WorkerTruckCouncilTwo>().TruckCouncilCanBeRobbed == true && PlayerHasEnteredTruckCouncilRobbingArea == true &&
            PlayerHasRobbedTruckCouncil == false && Input.GetKeyUp(KeyCode.F))
        {
            PlayerHasRobbedTruckCouncil = true;

            GameManager.GetComponent<DR_GameManager>().money += 200; // Change this variable to change how much money the player gains, when they rob the truck council
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            PlayerHasEnteredTruckCouncilRobbingArea = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            PlayerHasEnteredTruckCouncilRobbingArea = false;
        }
    }
}
