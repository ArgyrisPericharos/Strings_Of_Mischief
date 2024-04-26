using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR_TruckCouncilRob : MonoBehaviour
{
    public bool PlayerHasRobbedTruckCouncil = false;

    public bool PlayerHasEnteredTruckCouncilRobbingArea = false;

    public GameObject Camera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.GetComponent<DR_WorkerTruckCouncilThree>().TruckCouncilCanBeRobbed == true && PlayerHasEnteredTruckCouncilRobbingArea == true &&
            PlayerHasRobbedTruckCouncil == false)
        {
            PlayerHasRobbedTruckCouncil = true;

            this.gameObject.GetComponent<GameManager>().money += 200; // Change this variable to change how much money the player gains, when they rob the truck council
        }
    }

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            if (Camera.GetComponent<WiimoteDemo>().MinusPressed)
            {
                PlayerHasEnteredTruckCouncilRobbingArea = true;
            }
            
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
