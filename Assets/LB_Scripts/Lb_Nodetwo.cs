using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lb_Nodetwo : MonoBehaviour
{

    public GameObject BarrieDown;
    public GameObject BarrieUp;

    // Start is called before the first frame update
    void Start()
    {

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
            BarrieDown.SetActive(true);
            BarrieUp.SetActive(false);

        }
    }
}
