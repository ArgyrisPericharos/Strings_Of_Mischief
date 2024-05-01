using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LB_GenFAn : MonoBehaviour
{
    NavMeshAgent agent;
    public bool BandOn;
    public Transform target;
    public Transform original;
    public float speed = 1f;
    public Transform Band;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(BandOn == true)
        {
            agent.destination = target.position;
            //agent.destination = this.transform.position;
            float singleStep = speed * Time.deltaTime;
            Vector3 targetrotation = Band.position - transform.position;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetrotation, singleStep, 0.0f);




            transform.rotation = Quaternion.LookRotation(newDirection);
        }
        else
        {
            agent.destination = original.position;
            
        }
    }
}
