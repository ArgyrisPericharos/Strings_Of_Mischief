using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LB_GenPublic : MonoBehaviour
{
    public Transform goal;
    public List<Transform> ListOfTransforms;
    public int ListNumber;
    public float Timer;
    NavMeshAgent agent;
    public bool BandOn;
    public Transform Band;
    public float speed = 1f;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
       Timer = 0;
       agent = GetComponent<NavMeshAgent>();
       ListNumber = Random.Range(0, 19);
       
    }

    // Update is called once per frame
    void Update()
    {
        
        
        Timer += Time.deltaTime;
        if (Timer >= 5 && BandOn == false)
        {
            goal = ListOfTransforms[ListNumber];
            ListNumber = Random.Range(0, 19);
            Timer = 0;
            agent.destination = goal.position;
        }
        else if (BandOn == true)
        {
            Timer = 1;
            agent.destination = this.transform.position;
            float singleStep = speed * Time.deltaTime;
            Vector3 targetrotation = Band.position - transform.position;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetrotation, singleStep, 0.0f);

            

            
            transform.rotation = Quaternion.LookRotation(newDirection);

        }
        
       
        
    }
}
