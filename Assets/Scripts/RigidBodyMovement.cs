using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMovement : MonoBehaviour
{
    public Camera MainCamera;
    private Vector3 PlayerMovementInput;

    [SerializeField] private Rigidbody PlayerBody;
    [Space]
    [SerializeField] private float Speed;
    [SerializeField] private float Jumpforce;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        PlayerMovementInput = new Vector3(MainCamera.GetComponent<WiimoteDemo>().StickZero, 0f, MainCamera.GetComponent<WiimoteDemo>().StickOne);

        MovePlayer();
    }
    private void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
        PlayerBody.velocity = new Vector3(MoveVector.x, PlayerBody.velocity.y, MoveVector.z); 
    }
}
