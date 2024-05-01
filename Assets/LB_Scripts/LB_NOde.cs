using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LB_NOde : MonoBehaviour
{
    public GameObject Stop;
    public Transform newPosition;
    public bool BarrierActive;
    public GameObject Car;
    public GameObject BarrieDown;
    public GameObject BarrieUp;
    public bool OnTheWay;
    // Start is called before the first frame update
    void Start()
    {
        BarrierActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CarFirst"))
        {
            BarrierActive = true;            
            //Debug.Log("Works");
            BarrieDown.SetActive(false);
            BarrieUp.SetActive(true);
            if (BarrierActive == true)
            {
                Car.GetComponent<LB_Car>().Node.position = newPosition.position;
                OnTheWay = true;

            }
        }
    }
}
