using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rollSpeed = 20f;

    private Rigidbody ballRigidbody;

    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
        ballRigidbody.constraints = RigidbodyConstraints.FreezeRotation;

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rollDirection = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0) * Vector3.forward;

        ballRigidbody.AddForce(rollDirection * rollSpeed * Time.deltaTime, ForceMode.Acceleration);

    }
}
