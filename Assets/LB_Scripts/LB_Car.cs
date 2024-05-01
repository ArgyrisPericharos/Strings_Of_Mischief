using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class LB_Car : MonoBehaviour
{
    NavMeshAgent car;
    public Transform Node;
    public List<Transform> ListOfNodes;
    //public Transform CarCar;

    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
            car.destination = Node.position;
        

    }
}
