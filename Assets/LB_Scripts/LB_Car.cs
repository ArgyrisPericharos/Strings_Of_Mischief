using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class LB_Car : MonoBehaviour
{
    public List<Transform> targets;
    private int currentTargetIndex = 0;
    private NavMeshAgent agent;
    public float checkRadius = 1.0f;
    public LayerMask agentLayerMask;
    public float proximityThreshold = 1.0f;
    private bool shouldStop = false;
    public Transform teleportDestination;
    public bool Playing;
    public bool TeleportDone;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Playing = true;
        TeleportDone = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (targets.Count == 0 || shouldStop) return;

        MoveToTarget();
        CheckForObstacles();

        if (Vector3.Distance(transform.position, targets[currentTargetIndex].position) <= proximityThreshold)
        {
            if (currentTargetIndex >= targets.Count - 1)
            {

                if (teleportDestination != null)
                {
                    agent.Warp(teleportDestination.position);
                    if (TeleportDone)
                    {
                        currentTargetIndex = 0;
                    }

                }
            }
            else
            {
                currentTargetIndex++;
            }
        }
    }
    void MoveToTarget()
    {
        if (currentTargetIndex < targets.Count && Playing)
        {
            agent.SetDestination(targets[currentTargetIndex].position);
        }
        else if (Playing == false)
        {
            agent.destination = this.transform.position;
        }
    }

    void CheckForObstacles()
    {
        RaycastHit hit;


        if (Physics.SphereCast(transform.position, checkRadius, transform.forward, out hit, 3.5f, agentLayerMask))
        {
            NavMeshAgent hitAgent = hit.collider.GetComponent<NavMeshAgent>();
            if (hitAgent != null)
            {
                shouldStop = true;
                agent.isStopped = true;
            }
            
        }
    }
}
