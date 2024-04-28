using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR_CrowdMemberAIMovement : MonoBehaviour
{
    public GameObject DR_GameManager;
    public GameObject CrowdMember;
    public GameObject ConcertCrowdMeetingPoint;
    public bool crowdMemberCanMoveFreely = true;
    public bool crowdMemberIsInsideCollisionSphere = false;
    public bool crowdMembersHaveBeenAttractedToConcert = false;
    public float crowdMemberRandomRotation;
    public float crowdMemberRandomMovementDistance;
    public float crowdMemberMovementDuration = 1.5f; // Change this variable to change how quickly the crowd member will get to their destination, every time they move
    public float crowdMemberMovementDurationTowardsConcert = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeRotationAndMovePeriodically());
    }

    // Update is called once per frame
    void Update()
    {
        if (DR_GameManager.GetComponent<DR_GameManager>().ConcertHasBeenStarted == true && crowdMembersHaveBeenAttractedToConcert == false)
        {
            crowdMembersHaveBeenAttractedToConcert = true;

            crowdMemberCanMoveFreely = false;

            if (crowdMemberIsInsideCollisionSphere == true)
            {
                ChangeCrowdMemberRotationTowardsConcert();

                crowdMemberCanMoveFreely = true;
            }
        }
    }

    public IEnumerator ChangeRotationAndMovePeriodically()
    {
        while (crowdMemberCanMoveFreely == true)
        {
            yield return new WaitForSeconds(5.0f); // Change this variable to change how much time will pass, between every movement of the crowd member

            ChangeCrowdMemberRotation();
            yield return new WaitForSeconds(crowdMemberMovementDuration);
        }
    }

    public void ChangeCrowdMemberRotation()
    {
        crowdMemberRandomRotation = Random.Range(0f, 360f);

        Quaternion newRotation = Quaternion.Euler(0f, crowdMemberRandomRotation, 0f);

        CrowdMember.gameObject.transform.rotation = newRotation;

        crowdMemberRandomMovementDistance = Random.Range(0.5f, 2.0f); // Change these two floats to change how far the crowd member will go, every time they move

        StartCoroutine(MoveCrowdMemberTowardsDirection(CrowdMember.transform.forward, crowdMemberRandomMovementDistance, crowdMemberMovementDuration));
    }

    public IEnumerator MoveCrowdMemberTowardsDirection(Vector3 crowdMemberMovementDirection, float crowdMemberMovementDistance, float crowdMemberMovementDuration)
    {
        float startCrowdMemberMovementTime = Time.time;
        Vector3 crowdMemberStartPosition = CrowdMember.transform.position;
        Vector3 crowdMemberEndPosition = crowdMemberStartPosition + crowdMemberMovementDirection * crowdMemberMovementDistance;

        while (Time.time - startCrowdMemberMovementTime < crowdMemberMovementDuration)
        {
            float t = (Time.time - startCrowdMemberMovementTime) / crowdMemberMovementDuration;
            CrowdMember.transform.position = Vector3.Lerp(crowdMemberStartPosition, crowdMemberEndPosition, t);
            yield return null;
        }

        CrowdMember.transform.position = crowdMemberEndPosition;
    }

    public void ChangeCrowdMemberRotationTowardsConcert()
    {
        CrowdMember.gameObject.transform.rotation = ConcertCrowdMeetingPoint.gameObject.transform.rotation;

        crowdMemberMovementDurationTowardsConcert = Random.Range(2.0f, 4.0f); // Change these two floats to change how far the crowd member will go, every time they move

        StartCoroutine(MoveCrowdMemberTowardsConcert(crowdMemberMovementDurationTowardsConcert));
    }

    public IEnumerator MoveCrowdMemberTowardsConcert(float crowdMemberMovementDurationTowardsConcert)
    {
        float startCrowdMemberMovementTime = Time.time;
        Vector3 crowdMemberStartPosition = CrowdMember.transform.position;
        Vector3 crowdMemberConcertCrowdMeetingPoint = ConcertCrowdMeetingPoint.transform.position;

        while (Time.time - startCrowdMemberMovementTime < crowdMemberMovementDurationTowardsConcert)
        {
            float t = (Time.time - startCrowdMemberMovementTime) / crowdMemberMovementDurationTowardsConcert;
            CrowdMember.transform.position = Vector3.Lerp(crowdMemberStartPosition, crowdMemberConcertCrowdMeetingPoint, t);
            yield return null;
        }

        CrowdMember.transform.position = crowdMemberConcertCrowdMeetingPoint;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ConcertCrowdAttractor")
        {
            crowdMemberIsInsideCollisionSphere = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ConcertCrowdAttractor")
        {
            crowdMemberIsInsideCollisionSphere = false;
        }
    }
}
