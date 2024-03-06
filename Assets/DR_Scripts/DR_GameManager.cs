using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DR_GameManager : MonoBehaviour
{
    public float money = 0.0f; // Change this variable to change how much money the player starts off with, at the start of each level

    public Text textMoney;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textMoney.text = "Money  =  $ " + money.ToString("F2");
    }
}
