using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LB_NOde : MonoBehaviour
{
   
  
   
  
    public GameObject BarrieDown;
    public GameObject BarrieUp;
    public bool TaxLeft;
    public GameObject CarFirst;

    
    // Start is called before the first frame update
    void Start()
    {
        TaxLeft = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CarFirst"))
        {
                       
            Debug.Log("Works");
            BarrieDown.SetActive(false);
            BarrieUp.SetActive(true);
            if (TaxLeft == true)
            {

                CarFirst.gameObject.GetComponent<LB_Car>().Playing = false;
                BarrieDown.SetActive(true);
                BarrieUp.SetActive(false);

            }
        }
    }
}
