using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LB_Wedding : MonoBehaviour
{
    public GameManager GameManager;
    public Transform Band;
    NavMeshAgent agent;
    public bool BandOn;
    private Vector3 original;
    private float speed = 1f;
    public float chanceofdistraction = 0f;
    public Transform Target;
    public bool isDistracted = false;
    public GameObject HandsUp;
    public GameObject RobTrigger;
    public Camera Camera;
    public bool PlayerInside;
    public bool Robbable;
    
    // Start is called before the first frame update
    void Start()
    {
        BandOn = false;
        original = this.transform.position;
        chanceofdistraction = Random.Range(0, 100);
        agent = GetComponent<NavMeshAgent>();
        Robbable = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (BandOn == true)
        {
           //agent.destination = this.transform.position;
            float singleStep = speed * Time.deltaTime;
            Vector3 targetrotation = Band.position - transform.position;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetrotation, singleStep, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);
            if (GameManager.CrowdSatisfaction >= 50 && chanceofdistraction >= 60) 
            
            {
                
                isDistracted=true;
                agent.destination = Target.position;
                if (isDistracted)
                {
                    HandsUp.SetActive(true);
                    RobTrigger.SetActive(true);
                }
            }
            else
            {
                isDistracted = false;
                HandsUp.SetActive(false);
                RobTrigger.SetActive(false);
            }

        }
        else if (BandOn!)
        {
            agent.destination = original;
            isDistracted = false;
            HandsUp.SetActive(false);
            RobTrigger.SetActive(false);
            Robbable = true;
        }
        if (isDistracted == true && PlayerInside == true && Camera.GetComponent<WiimoteDemo>().MinusPressed && Robbable)
        {
            GameManager.GetComponent<GameManager>().money += Random.Range(5, 25);
            Robbable = false;
        }
    }
}
