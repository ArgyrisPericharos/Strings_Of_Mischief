using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR_CrowdMemberAIMovement : MonoBehaviour
{
    public GameObject CrowdMember;
    public float crowdMemberRandomRotation;
    public float crowdMemberRandomMovementDistance;
    public float crowdMemberMovementDuration = 1.5f; // Change this variable to change how quickly the crowd member will get to their destination, every time they move

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeRotationAndMovePeriodically());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ChangeRotationAndMovePeriodically()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f); // Change this variable to change how much time will pass, between every movement of the crowd member

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

    IEnumerator MoveCrowdMemberTowardsDirection(Vector3 crowdMemberMovementDirection, float crowdMemberMovementDistance, float crowdMemberMovementDuration)
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
}
