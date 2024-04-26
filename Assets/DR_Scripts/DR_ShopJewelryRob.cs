using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DR_ShopJewelryRob : MonoBehaviour
{
    public GameObject GameManager;

    public bool PlayerHasRobbedShopJewelry = false;

    public bool PlayerHasEnteredShopJewelryRobbingArea = false;

    public GameObject Camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.GetComponent<DR_ShopJewelry>().ShopJewelryCanBeRobbed == true && PlayerHasEnteredShopJewelryRobbingArea == true &&
            PlayerHasRobbedShopJewelry == false)
        {
            PlayerHasRobbedShopJewelry = true;

            GameManager.GetComponent<DR_GameManager>().money += 1000; // Change this variable to change how much money the player gains, when they rob the shop jewelry
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            
            if (Camera.GetComponent<WiimoteDemo>().MinusPressed)
            {
                    PlayerHasEnteredShopJewelryRobbingArea = true;
            }
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            PlayerHasEnteredShopJewelryRobbingArea = false;
        }
    }
}
