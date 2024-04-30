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
    public GameObject BandReal;
    public bool DisableGoal;
    
    
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

        }
        else if (BandOn == true)
        {
            goal.position = BandReal.transform.position;
       }
        /*else if (BandOn == true)
        {
            goal.position = agent.transform.position;
        }*/





      
        
        agent.destination = goal.position;
    }
}
