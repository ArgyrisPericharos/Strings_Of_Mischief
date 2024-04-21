using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR_PolicemanAIMovement : MonoBehaviour
{
    public GameObject Policeman;
    public float policemanRandomRotation;
    public float policemanRandomMovementDistance;
    public float policemanMovementDuration = 1.5f; // Change this variable to change how quickly the policeman will get to their destination, every time they move

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
            yield return new WaitForSeconds(3f); // Change this variable to change how much time will pass, between every movement of the policeman

            ChangePolicemanRotation();
            yield return new WaitForSeconds(policemanMovementDuration);
        }
    }

    public void ChangePolicemanRotation()
    {
        policemanRandomRotation = Random.Range(0f, 360f);

        Quaternion newRotation = Quaternion.Euler(0f, policemanRandomRotation, 0f);

        Policeman.gameObject.transform.rotation = newRotation;

        /*
        policemanRandomMovementDistance = Random.Range(0.5f, 2.0f); // Change these two floats to change how far the policeman will go, every time they move

        StartCoroutine(MovePolicemanTowardsDirection(Policeman.transform.forward, policemanRandomMovementDistance, policemanMovementDuration));
        */
    }

    /*
    IEnumerator MovePolicemanTowardsDirection(Vector3 crowdMemberMovementDirection, float crowdMemberMovementDistance, float policemanMovementDuration)
    {
        float startPolicemanMovementTime = Time.time;
        Vector3 crowdMemberStartPosition = Policeman.transform.position;
        Vector3 crowdMemberEndPosition = crowdMemberStartPosition + crowdMemberMovementDirection * crowdMemberMovementDistance;

        while (Time.time - startPolicemanMovementTime < policemanMovementDuration)
        {
            float t = (Time.time - startPolicemanMovementTime) / policemanMovementDuration;
            Policeman.transform.position = Vector3.Lerp(crowdMemberStartPosition, crowdMemberEndPosition, t);
            yield return null;
        }

        Policeman.transform.position = crowdMemberEndPosition;
    }
    */
}
