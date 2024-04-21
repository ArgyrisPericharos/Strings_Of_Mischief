using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR_Boxcast : MonoBehaviour
{
    float m_MaxDistance;
    bool m_HitDetect;
    public Vector3 colliderBoxSize;
    Collider m_Collider;
    RaycastHit m_Hit;
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;

    public bool DoNotOutputGameObjectThatHasBeenHitByBoxcast = true;

    void Start()
    {
        //Choose the distance the Box can reach to
        m_MaxDistance = 100.0f;
        m_Collider = GetComponent<Collider>();
    }

    void FixedUpdate()
    {
        //Test to see if there is a hit using a BoxCast
        //Calculate using the center of the GameObject's Collider(could also just use the GameObject's position), half the GameObject's size, the direction, the GameObject's rotation, and the maximum distance as variables.
        //Also fetch the hit data
        m_HitDetect = Physics.BoxCast(m_Collider.bounds.center, colliderBoxSize / 2, transform.forward, out m_Hit, transform.rotation, m_MaxDistance);
        if (m_HitDetect && DoNotOutputGameObjectThatHasBeenHitByBoxcast == false)
        {
            //Output the name of the Collider your Box hit
            Debug.Log("A game object has been hit by the boxcast.");
        }
    }

    void Update()
    {
        if (m_Hit.collider.tag == "Player")
        {
            Player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();

            Debug.Log("You have been spotted by a policeman.");
        }
    }

    //Draw the BoxCast as a gizmo to show where it currently is testing. Click the Gizmos button to see this
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        //Check if there has been a hit yet
        if (m_HitDetect)
        {
            //Draw a Ray forward from GameObject toward the hit
            Gizmos.DrawRay(transform.position, transform.forward * m_Hit.distance);
            //Draw a cube that extends to where the hit exists
            Gizmos.DrawWireCube(transform.position + transform.forward * m_Hit.distance, colliderBoxSize);
        }

        //If there hasn't been a hit yet, draw the ray at the maximum distance
        else
        {
            //Draw a Ray forward from GameObject toward the maximum distance
            Gizmos.DrawRay(transform.position, transform.forward * m_MaxDistance);
            //Draw a cube at the maximum distance
            Gizmos.DrawWireCube(transform.position + transform.forward * m_MaxDistance, colliderBoxSize);
        }
    }
}
