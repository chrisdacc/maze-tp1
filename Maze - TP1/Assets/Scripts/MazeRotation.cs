using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRotation : MonoBehaviour
{
    public float rotationSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        float horizontalRotateInput = Input.GetAxis("Horizontal");
        float verticalRotateInput = Input.GetAxis("Vertical");
        
        float rotationX = verticalRotateInput * rotationSpeed * Time.deltaTime;
        float rotationY = horizontalRotateInput * rotationSpeed * Time.deltaTime;

        transform.Rotate(Vector3.right, rotationX);
        transform.Rotate(Vector3.up, rotationY);
    }
}
